using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using HRMEFentity.MyContext;
using System.Data.Entity.Infrastructure;
namespace HRMDAO
{
    public class DaoBase<T> where T : class
    {
        //用于监测Context中的Entity是否存在，如果存在，将其Detach，防止出现问题。
        private Boolean RemoveHoldingEntityInContext(T entity)
        {
            var objContext = ((IObjectContextAdapter)db).ObjectContext;
            var objSet = objContext.CreateObjectSet<T>();
            var entityKey = objContext.CreateEntityKey(objSet.EntitySet.Name, entity);

            Object foundEntity;
            var exists = objContext.TryGetObjectByKey(entityKey, out foundEntity);

            if (exists)
            {
                objContext.Detach(foundEntity);
            }

            return (exists);
        }

        /*using (TestDbContext ts = new TestDbContext()) {}*/
        //因为 在同一个页面可能多次调用 必须操持每次的db是同一个 所以写出了下面的代码 --> 让方法去判断是不是同一个页面调用
        static TestContext db = CreateDbContext();

        //判断是不是同一个页面调用创建的db
        private static TestContext CreateDbContext()
        {
            //从当前请求的线程取值
            db = CallContext.GetData("CTInfo") as TestContext;//Get
            if (db == null)
            {
                db = new TestContext();
                //把上下文对象存入当前请求的线程中
                CallContext.SetData("CTInfo", db);//Set
            }
            return db;
        }

        /// <summary>
        /// 添加到数据库的方法
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public int Add(T t)
        {
            /*Students st = new Students()
            {
                Name = "Test",
            };
            db.Student.Add(st);*/

            //Set<T>()等于Students
            db.Set<T>().Add(t);
            return db.SaveChanges();
        }

        /// <summary>
        /// 修改数据的方法
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public int Update(T t)
        {
            /*
            Student UDstu = new Student()
                {
                    Id = 1,
                    Name = "TestUD",
                    //Age = 19,如果有没赋值的属性 这个属性的值在修改后将等于Null 
                    ClassId = 1
                };
            db.Entry(UDstu).State = EntityState.Modified;
            db.SaveChanges();
            */
            RemoveHoldingEntityInContext(t);
            db.Entry(t).State = EntityState.Modified;
            return db.SaveChanges();
        }

        /// <summary>
        /// 删除的方法
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public int Delete(T t)
        {

            /*
                          Student StuDel = new Student()
                            {
                                Id = 5
                            };
                            db.Entry(StuDel).State = EntityState.Deleted;//直接让它的状态定位到删除状态*/

            RemoveHoldingEntityInContext(t);
            db.Entry(t).State = EntityState.Deleted;
            return db.SaveChanges();

        }

        /// <summary>
        /// 查询全部
        /// </summary>
        /// <returns></returns>
        public List<T> QueryAll()
        {

            //var result = db.Students.
            //    Select(e => e);
            //Set<T>() --> Students
            List<T> list = db.Set<T>().Select(e => e).AsNoTracking().ToList();
            return list;

        }


        /// <summary>
        /// 模糊查询
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public List<T> SelectByx(Expression<Func<T, bool>> where)
        {

            /*var result = test.Students
                .Where(e => e.Name.Contains("est") && e.Age.Equals(19))
                .Select(e=>new { Id=e.Id,Name=e.Name});*/

            List<T> list = db.Set<T>().Where(where)// .Where(e => e.Name.Contains("est") && e.Age.Equals(19))
                .Select(e => e)
                .AsNoTracking()
                .ToList();

            return list;
        }

        /// <summary>
        /// 分页查询
        /// </summary>
        /// <typeparam name="K"></typeparam>
        /// <param name="order">排序条件</param>
        /// <param name="where">筛选条件</param>
        /// <param name="rows">总记录数</param>
        /// <param name="currentPage">当前页</param>
        /// <param name="pageSize">每页显示数</param>
        /// <returns></returns>
        public List<T> Paging<K>(Expression<Func<T, K>> order, Expression<Func<T, bool>> where, ref int rows, int currentPage, int pageSize)
        {
            /*
var result= test.Students.OrderBy(e => e.Id)
      .Skip((2 - 1) * 1)  //(当前页-1)*每页显示数
      .Take(1)             //每页显示数
      .ToList();*/

            var data = db.Set<T>().OrderBy(order).Where(where).AsNoTracking();
            rows = data.Count();//获取总行数

            List<T> list = data.Skip((currentPage - 1) * pageSize)//Skip --> 分页的方法 跳过几条数据
                      .Take(pageSize)//显示几条数据
                      .ToList();
            return list;

            //总页数 = (总记录数 + 每页显示数 - 1) / 每页显示数
        }
    }
}
