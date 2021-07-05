using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using JSONFw.Models;

namespace testprojjsonframework.BusinessLogic
{
    public class BLEntryRequests
    {
        JSONFw.EntityClasses.jinsasan2db db = new JSONFw.EntityClasses.jinsasan2db();
        internal void AddRequestWith1Field(string formtype, string title)
        {
            db.EntryRequests.Add(new JSONFw.EntityClasses.EntryRequest()
            {
                RequestBy = "Auto",
                RequestTime = DateTime.UtcNow,
                RequestType = formtype.ToLower(),
                Status = "Pending",
                Text1 = title
            });
            db.SaveChanges();
        }

        internal void AddRequestWith1FieldAndKey(string formtype, string key, string title)
        {
            db.EntryRequests.Add(new JSONFw.EntityClasses.EntryRequest()
            {
                RequestBy = "Auto",
                RequestTime = DateTime.UtcNow,
                RequestType = formtype.ToLower(),
                Status = "Pending",
                Text1 = title,
                Key1 = key
            });
            db.SaveChanges();
        }

        internal void AddRequestWith2FieldAndKey(string formtype, string key, string title, string text1)
        {
            db.EntryRequests.Add(new JSONFw.EntityClasses.EntryRequest()
            {
                RequestBy = "Auto",
                RequestTime = DateTime.UtcNow,
                RequestType = formtype.ToLower(),
                Status = "Pending",
                Text1 = title,
                Text2 = text1,
                Key1 = key
            });
            db.SaveChanges();
        }


        internal void AddRequestWith2Field(string formtype, string title, string text2)
        {
            db.EntryRequests.Add(new JSONFw.EntityClasses.EntryRequest()
            {
                RequestBy = "Auto",
                RequestTime = DateTime.UtcNow,
                RequestType = formtype.ToLower(),
                Status = "Pending",
                Text1 = title,
                Text2 = text2
            });
            db.SaveChanges();
        }

        internal void AddRequestWith3Field(string formtype, string title, string text2, string text3)
        {
            db.EntryRequests.Add(new JSONFw.EntityClasses.EntryRequest()
            {
                RequestBy = "Auto",
                RequestTime = DateTime.UtcNow,
                RequestType = formtype.ToLower(),
                Status = "Pending",
                Text1 = title,
                Text2 = text2,
                Text3 = text3
            });
            db.SaveChanges();
        }
    }
}