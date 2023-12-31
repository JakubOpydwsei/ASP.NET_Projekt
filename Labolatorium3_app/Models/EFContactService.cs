﻿using Data.Entities;
using Data;
using Microsoft.EntityFrameworkCore;

namespace Labolatorium3_app.Models
{
    public class EFContactService : IContactService
    {
        private AppDbContext __ctx;
        public EFContactService(AppDbContext ctx)
        {
            __ctx = ctx;
        }
        public int Add(Contact contact)
        {
            var e = __ctx.Contacts.Add(ContactMapper.ToEntity(contact));
            int id = e.Entity.ContactId;
            __ctx.SaveChanges();
            return id;
        }




        public void Delete(int id)
        {
            ContactEntity? find = __ctx.Contacts.Find(id);
            if (find != null)
            {
                __ctx.Contacts.Remove(find);
                __ctx.SaveChanges();
            }
        }

        public List<Contact> FindAll()
        {
            return __ctx.Contacts
                .Include(c => c.Organization) // Include the Organizations property
                .Select(e => ContactMapper.FromEntity(e))
                .ToList();
        }
        public List<OrganizationEntity> FindAllOrganizations()
        {
            return __ctx.Organizations.ToList();
        }
        public Contact? FindById(int id)
        {
            ContactEntity? find = __ctx.Contacts.Find(id);
            return find != null ? ContactMapper.FromEntity(find) : null;
        }

        public void Update(Contact contact)
        {
            __ctx.Contacts.Update(ContactMapper.ToEntity(contact));
            __ctx.SaveChanges();
        }
    }
}
