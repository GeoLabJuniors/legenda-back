using legenda.Models;
using legenda.Models.Entities;
using legenda.Models.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace legenda.Services
{
    public class StaticDataService
    {
        private ApplicationDbContext db;

        public StaticDataService()
        {
            db = new ApplicationDbContext();
        }

        public MessageVM UpdateContact(ContactVM contact)
        {
            var message = new MessageVM
            {
                Title = "kontaktis shecva",
                Description = "warmatebiT sheicvala",
                Success = true,
            };

            var Mobile = InsertStaticData("Mobile", contact.Mobile);
            var Address = InsertStaticData("Address", contact.Address);
            var FBPage = InsertStaticData("FBPage", contact.FBPage);
            var Email = InsertStaticData("Email", contact.Email);

            if (!Mobile && !Address && !FBPage && !Email)
            {
                message.Description = "dafiqsirda shecdoma";
                message.Success = false;
            }

            return message;
        }
        public ContactVM GetContact()
        {
            var contact = new ContactVM();

            contact.Mobile = db.StaticData.Where(x => x.KeyWord == "Mobile").FirstOrDefault()?.Value;
            contact.Address = db.StaticData.Where(x => x.KeyWord == "Address").FirstOrDefault()?.Value;
            contact.Email = db.StaticData.Where(x => x.KeyWord == "Email").FirstOrDefault()?.Value;
            contact.FBPage = db.StaticData.Where(x => x.KeyWord == "FBPage").FirstOrDefault()?.Value;
            return contact;
        }

        public MessageVM UpdateAbout(string AboutTitle, string AboutDescription)
        {
            var message = new MessageVM
            {
                Title = "აბოუთის shecva",
                Description = "warmatebiT sheicvala",
                Success = true,
            };

            var aboutTitle = InsertStaticData("AboutTitle", AboutTitle);
            var aboutDescription = InsertStaticData("AboutDescription", AboutDescription);

            if (!aboutTitle && !aboutDescription)
            {
                message.Description = "dafiqsirda shecdoma";
                message.Success = false;
            }

            return message;
        }

        public List<string> GetAbout()
        {

            var AboutTitle = db.StaticData.Where(x => x.KeyWord == "AboutTitle").FirstOrDefault()?.Value;
            var AboutDescription = db.StaticData.Where(x => x.KeyWord == "AboutDescription").FirstOrDefault()?.Value;
            return new List<string> { AboutTitle, AboutDescription };
        }
        private bool InsertStaticData(string key, string value)
        {

            try
            {
                var exsistKey = db.StaticData.Where(x => x.KeyWord == key).FirstOrDefault();
                if (exsistKey != null)
                {
                    db.StaticData.Where(x => x.KeyWord == key).FirstOrDefault().Value = value;
                }
                else
                {
                    var newItem = new StaticData
                    {
                        KeyWord = key,
                        Value = value
                    };
                    db.StaticData.Add(newItem);
                }
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}