﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace aloorS6.Model
{
    public class Booking
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? bookingId { set; get; }
        public String name { set; get; }
        public String lastName { set; get; }
        public String description { set; get; }
        public String email { set; get; }
        public Boolean status { set; get; }
        public string statusName => status ? "ACTIVO" : "INACTIVO";
        public Boolean deleted { set; get; }

        public Booking(int bookingId, string name, string lastName, string description, string email, bool status, bool deleted)
        {
            this.bookingId = bookingId;
            this.name = name;
            this.lastName = lastName;
            this.description = description;
            this.email = email;
            this.status = status;
            this.deleted = deleted;
        }
        public Booking() { }

    }
    }
