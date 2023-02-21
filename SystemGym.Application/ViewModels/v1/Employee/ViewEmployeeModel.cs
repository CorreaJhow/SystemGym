using System;
using SystemGym.Domain.Enum.v1;

namespace SystemGym.Application.ViewModels.v1.Employee
{
    public class ViewEmployeeModel
    {
        public ViewEmployeeModel(string name, PositionEnum position, DateTime hiringDate, bool active, string document)
        {
            Name = name;
            Position = position;
            HiringDate = hiringDate;
            Active = active;
            Document = document;
        }

        public string Name { get; set; }
        public PositionEnum Position { get; private set; }
        public DateTime HiringDate { get; set; }
        public bool Active { get; set; }
        public string Document { get; set; }
    }
}
