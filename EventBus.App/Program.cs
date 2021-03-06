﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventBus.App.CustomEvents;

namespace EventBus.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Bus.EventBus sut = new Bus.EventBus();
            
            sut.Subscribe<MySimpleEventData>((dto) =>
            {
                Console.WriteLine(dto.Message);
            });

           
            sut.Publish(new MySimpleEventData("hello world 1"));
            sut.Publish(new MySimpleEventData("hello world 2"));
            sut.Publish(new MySimpleEventData("hello world 3"));

            Console.ReadKey();
        }
    }
}
