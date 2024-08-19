using Domain.Dtos;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.IServices
{
    public interface ITraineeService
    {
        Task<List<Trainee>> GetTraineesList();
        Task<Trainee> GetTraineeByIdAsync(Guid IdTrainee);
       
        Task<TraineeDto> AddTraineeAsync(TraineeDto trainee);
     
        Task UpdateTraineeAsync(Trainee trainee);
        Task DeleteTraineeAsync(Guid IdTrainee);
        Task<List<Trainee>> GetListTraineesFormKafkaAsync();
    }
}
