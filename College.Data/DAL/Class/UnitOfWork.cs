using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace College.Data.DAL.Class
{
    public class UnitOfWork : IDisposable
    {
        private SampleDBContext context = new SampleDBContext();
        private GenericRepository<Student> studentRepository;
        private GenericRepository<Course> courseRepository;
        private GenericRepository<StudentAddress> studentAddressRepository;
        private GenericRepository<Teacher> teacherRepository;
        private GenericRepository<Standard> standardRepository;

        public GenericRepository<Student> StudentRepository
        {
            get
            {

                if (this.studentRepository == null)
                {
                    this.studentRepository = new GenericRepository<Student>(context);
                }
                return studentRepository;
            }
        }

        public GenericRepository<Course> CourseRepository
        {
            get
            {

                if (this.courseRepository == null)
                {
                    this.courseRepository = new GenericRepository<Course>(context);
                }
                return courseRepository;
            }
        }

        public GenericRepository<StudentAddress> StudentAddressRepository
        {
            get
            {

                if (this.studentAddressRepository == null)
                {
                    this.studentAddressRepository = new GenericRepository<StudentAddress>(context);
                }
                return studentAddressRepository;
            }
        }

        public GenericRepository<Teacher> TeacherRepository
        {
            get
            {

                if (this.teacherRepository == null)
                {
                    this.teacherRepository = new GenericRepository<Teacher>(context);
                }
                return teacherRepository;
            }
        }

        public GenericRepository<Standard> StandardRepository
        {
            get
            {

                if (this.standardRepository == null)
                {
                    this.standardRepository = new GenericRepository<Standard>(context);
                }
                return standardRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}