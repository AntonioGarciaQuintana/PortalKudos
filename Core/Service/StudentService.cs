using Core.Model;
using Core.Repository.Interfaces;
using Core.Service.Interfaces;
using Core.Util.Email;
using Core.Util.Email.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Service
{
    public class StudentService : IStudentService
    {
        private readonly IUnitOfWork UnitOfWork;

        public StudentService(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }

        public List<Student> GetStudents()
        {
            return UnitOfWork.GetRepository<Student>().GetAll().Where(s => s.IsDeleted == false).ToList();
        }

        public void sendEmail()
        {
            IMailer mailer = new Mailer();
            mailer.sendEmail("tony_16_fagq@hotmail.com","test subjet", "<h1>Mailer Test</h1>");
        }
    }
}
