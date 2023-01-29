using SystemGym.Domain.Enum.v1;

namespace SystemGym.Application.InputModels.v1.Employee
{
    public class UpdatePositionEmployeeInputModel
    {
        public string Document { get; set; }
        public PositionEnum Position { get; set; }
    }
}
