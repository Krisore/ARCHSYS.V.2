using ARCHSYS.CORE;
using Microsoft.EntityFrameworkCore;
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

    protected override void OnModelCreating(ModelBuilder modelBuilder) 
    {
        //SINEEEED KO UNG DATA DITO MGA LODS : 
        modelBuilder.Entity<Document>().HasData(
                new Document
                {
                   Id = 1,
                   Title = "PUPBC : Chatbot",
                   ShortDiscription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book." +
                    "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                   DatePublished = new DateTime(2022, 03, 25)

                },
                new Document
                {
                    Id = 2,
                    Title = "PUPBC : Inventory System",
                    ShortDiscription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book." +
                    "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                    DatePublished = new DateTime(2022, 03, 25)

                },
                new Document
                {
                    Id = 3,
                    Title = "PUPBC : Archiving System",
                    ShortDiscription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book." +
                    "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                    DatePublished = new DateTime(2022, 03, 25)
                },
                 new Document
                 {
                     Id = 4,
                     Title = "PUPBC : Room Management System",
                     ShortDiscription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.Lorem Ipsum is simply dummy text of the printing and typesetting industry. " +
                    "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                     DatePublished = new DateTime(2022, 03, 25)
                 },
                 new Document 
                 {
                     Id = 5,
                     Title = "Kadet Progress Monitoring and Coach Task Designation System for a\r\nCareer Development Organization with Collaborative Technology",
                     ShortDiscription = "The developed system is purposely done by the developers for their\r\nclient Kadakareer.A non - profit organization that has the goal to bring the\r\nbridge to the career gap of the local youth residing in the rural areas of the\r\nPhilippines.The task designation and monitoring system developed is linked\r\nto the existing web application of KadaKareer which is the Coach Connector.\r\nIn accordance with the objectives, the developers met the following\r\nobjectives: develop the system that matches the need of the target users and\r\nevaluate the system in terms of functional suitability and usability.",
                     DatePublished = new DateTime(2022, 03, 26)
                 });
    }
}
