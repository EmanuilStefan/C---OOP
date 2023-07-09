using BorderControl.Models;
using BorderControl.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorderControl.Interfaces;

public class Engine : IEngine
{
    public void Run()
    {
        IIdentifiable subject;
        List<IIdentifiable> subjects = new();
        string command;
        while ((command = Console.ReadLine()) != "End")
        {
            string[] inputData = command
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (inputData.Length == 3)
            {
                subject = new Citizen(inputData[0], int.Parse(inputData[1]), inputData[2]);
                subjects.Add(subject);
            }
            if (inputData.Length == 2)
            {
                subject = new Robot(inputData[0], inputData[1]);
                subjects.Add(subject);
            }
        }
        string fakeId = Console.ReadLine();

        foreach(IIdentifiable incomer in subjects)
        {
            if (incomer.Id.EndsWith(fakeId))
            {
                Console.WriteLine(incomer.Id);
            }
        }
    }
}
