using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace GameMillionare_MVC_.Models.Repository
{
    public class SqlRepository : IRepository<Answer>
    {
        static QuestionContext qc;
        public SqlRepository()
        {
            qc = new QuestionContext();
        }
        private bool disposed = false;
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    qc.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        public List<Answer> GetAnswers(int val)
        {
            return qc.Answers.Include(p => p.Question).Take(val * 4).ToList();
        }   
    }
}