﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtSepete.RabbitMQ.ESB.MassTransit.Shared.Messages
{
    public class CreateOrdersMessage:IMessage
    {
        public string Text { get; set; }

    }
}
