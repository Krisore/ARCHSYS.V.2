using ARCHSYS.CORE;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ARCHSYS.PLUGINS_INMEMORY;

public class ARCHSYSContext : DbContext
{
    public ARCHSYSContext(DbContextOptions options) : base(options)
    {

    }
    public DbSet<Document> Documents { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<AcademicProgram> AcademicPrograms { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder) 
    {
        //!!IMPORTANT ALL SEEDED DATA: 
        modelBuilder.Entity<AcademicProgram>().HasData(
            new AcademicProgram
            {
                Id = 1,
                Name = "Bachelor of Science in Information Technology",
                Acronym = "BSIT"
            },
            new AcademicProgram
            {
                Id = 2,
                Name = "Bachelor of Science in Computer Engineering",
                Acronym = "BSCpE"
            }
            );    
        modelBuilder.Entity<Author>().HasData(
                        new Author
                        {
                             AuthorId = 1,
                             FirstName = "Priya",
                             LastName = "Shadya",
                             MiddleInitial = "Van",
                             DocumentId = 1,
                             AcademicProgramId = 1
                        },
                        new Author
                        {
                            AuthorId = 2,
                            FirstName = "Katharina",
                            LastName = "Malini",
                            MiddleInitial = " Mata",
                            DocumentId = 1,
                            AcademicProgramId = 1
                        },
                        new Author
                        {
                            AuthorId = 3,
                            FirstName = "Katharina",
                            LastName = "Malini",
                            MiddleInitial = " M",
                            DocumentId = 1,
                            AcademicProgramId = 1
                        },
                         new Author
                         {
                             AuthorId = 4,
                             FirstName = "Eveleen",
                             LastName = "Mihaela",
                             MiddleInitial = "S",
                             DocumentId = 3,
                             AcademicProgramId = 1
                         },
                        new Author
                        {
                            AuthorId = 5,
                            FirstName = "Marilyn",
                            LastName = "Dejana ",
                            MiddleInitial = "S",
                            DocumentId = 3,
                            AcademicProgramId = 1
                        },
                        new Author
                        {
                            AuthorId = 6,
                            FirstName = "Radana",
                            LastName = " Anželika",
                            MiddleInitial = "C",
                            DocumentId = 3,
                            AcademicProgramId = 1
                        },
                         new Author
                         {
                             AuthorId = 7,
                             FirstName = "Eveleen",
                             LastName = "Mihaela",
                             MiddleInitial = "S",
                             DocumentId = 4,
                             AcademicProgramId = 1
                         },
                        new Author
                        {
                            AuthorId = 8,
                            FirstName = "Marilyn",
                            LastName = "Dejana ",
                            MiddleInitial = "S",
                            DocumentId = 4,
                            AcademicProgramId = 1
                        },
                        new Author
                        {
                            AuthorId = 9,
                            FirstName = "Radana",
                            LastName = " Anželika",
                            MiddleInitial = "C",
                            DocumentId = 4,
                            AcademicProgramId = 1
                        },
                        new Author
                        {
                            AuthorId = 10,
                            FirstName = "Eveleen",
                            LastName = "Mihaela",
                            MiddleInitial = "S",
                            DocumentId = 5,
                            AcademicProgramId = 1
                        },
                        new Author
                        {
                            AuthorId = 11,
                            FirstName = "Marilyn",
                            LastName = "Dejana ",
                            MiddleInitial = "S",
                            DocumentId = 5,
                            AcademicProgramId = 1
                        },
                        new Author
                        {
                            AuthorId = 12,
                            FirstName = "Radana",
                            LastName = " Anželika",
                            MiddleInitial = "C",
                            DocumentId = 5,
                            AcademicProgramId = 1
                        },
                         new Author
                         {
                             AuthorId = 13,
                             FirstName = "Priya",
                             LastName = "Shadya",
                             MiddleInitial = "Van",
                             DocumentId = 2,
                             AcademicProgramId = 1
                         },
                        new Author
                        {
                            AuthorId = 14,
                            FirstName = "Katharina",
                            LastName = "Malini",
                            MiddleInitial = " Mata",
                            DocumentId = 2,
                            AcademicProgramId = 1
                        },
                        new Author
                        {
                            AuthorId = 15,
                            FirstName = "Katharina",
                            LastName = "Malini",
                            MiddleInitial = " M",
                            DocumentId = 2,
                            AcademicProgramId = 1
                        }
                        );
        modelBuilder.Entity<Document>().HasData(
                new Document
                {
                    Id = 1,
                    ShortDiscription = "There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn't anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary,",
                    Title = "PUPBC : Chatbot",
                    Abstract = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book." +
                    "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                     DatePublished = new DateTime(2022, 03, 25),
                    AcademicProgramId = 1,
                    IsActive = true

                },
                new Document
                {
                    Id = 2,
                    ShortDiscription = "There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn't anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary,",
                    Title = "PUPBC : Inventory System",
                    Abstract = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book." +
                    "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                    DatePublished = new DateTime(1999, 03, 25),
                    AcademicProgramId = 1,
                    IsActive = false

                },
                new Document
                {
                    Id = 3,
                    Title = "PUPBC : Archiving System",
                    ShortDiscription = "There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn't anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary,",
                    Abstract = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book." +
                    "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                    DatePublished = new DateTime(2022, 03, 25),
                    AcademicProgramId = 1,
                    IsActive = true
                },
                 new Document
                 {
                     Id = 4,
                     ShortDiscription = "There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn't anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary,",
                     Title = "PUPBC : Room Management System",
                     Abstract = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.Lorem Ipsum is simply dummy text of the printing and typesetting industry. " +
                    "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                     DatePublished = new DateTime(2012, 03, 25),
                     AcademicProgramId = 1,
                     IsActive = false
                 },
                 new Document 
                 {
                     Id = 5,
                     ShortDiscription = "There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn't anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary,",
                     Title = "Kadet Progress Monitoring and Coach Task Designation System for a\r\nCareer Development Organization with Collaborative Technology",
                     Abstract = "The developed system is purposely done by the developers for their\r\nclient Kadakareer.A non - profit organization that has the goal to bring the\r\nbridge to the career gap of the local youth residing in the rural areas of the\r\nPhilippines.The task designation and monitoring system developed is linked\r\nto the existing web application of KadaKareer which is the Coach Connector.\r\nIn accordance with the objectives, the developers met the following\r\nobjectives: develop the system that matches the need of the target users and\r\nevaluate the system in terms of functional suitability and usability.",
                     DatePublished = new DateTime(2022, 03, 26),
                     AcademicProgramId = 1,
                     IsActive = true

                 });
    }
}
