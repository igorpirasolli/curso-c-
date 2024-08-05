﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using enunn.entidades.Enums;

namespace enunn.entidades
{
    internal class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public Order(int id, DateTime moment, OrderStatus status)
        {
            Id = id;
            Moment = moment;
            Status = status;
        }

        public override string ToString()
        {
            return $"{Id}, {Moment}, {Status}";
        }
    }
}
