﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Client.Models.DB;

namespace Client.Models.DTO
{
    public class AccountStaff : Account
    {
        public Account account { get; set; }
        public Staff staff { get; set; }
        public List<Img> imgs { get; set; }
        public List<Service_> services { get; set; }
        public List<Detail> details { get; set; }

        public AccountStaff()
        {
            account = new Account();
            staff = new Staff();
            imgs = new List<Img>();
            services = new List<Service_>();
            details = new List<Detail>();

        }
        public AccountStaff(Account account, Staff staff, List<Img> imgs, List<Service_> services, List<Detail> details)
        {
            this.account = account ?? throw new ArgumentNullException(nameof(account));
            this.staff = staff ?? throw new ArgumentNullException(nameof(staff));
            this.imgs = imgs;
            this.services = services;
            this.details = details;
        }
    }
}