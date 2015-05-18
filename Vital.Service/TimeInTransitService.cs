using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vital.Data.Models;
using Repository;

namespace Vital.Service
{
    public class TimeInTransitService : ITimeInTransitService
    {

        readonly IRepository<TimeInTransitCode> _timeInTransitCodeRepository;
        readonly IUnitOfWork _unitOfWork;

        public TimeInTransitService(IRepository<TimeInTransitCode> timeInTransitCodeRepository, IUnitOfWork unitOfWork)
        {
            this._timeInTransitCodeRepository = timeInTransitCodeRepository;
            this._unitOfWork = unitOfWork;
        }

        public TimeInTransitCode GetTimeInTransitCode(string from, string to, string code)
        {
            return GetTimeInTransitCodes(from, to).FirstOrDefault(r => r.Code == code);
        }

        public IEnumerable<TimeInTransitCode> GetTimeInTransitCodes(string from, string to)
        {
            var data = _timeInTransitCodeRepository.Query().Get().ToList();

            switch (from.ToUpper())
            {
                case "PL":
                    data = data.Where(r => r.From == "PL").ToList();
                    break;
                case "PR":
                    data = data.Where(r => r.From == "PR").ToList();
                    break;
                case "MX":
                    data = data.Where(r => r.From == "MX").ToList();
                    break;
                case "CA":
                    data = data.Where(r => r.From == "CA").ToList();
                    break;
                case "US":
                    data = data.Where(r => r.From == "US").ToList();
                    break;
                default:
                    data = data.Where(r => r.From == "ANY").ToList();
                    break;
            }

            switch (to.ToUpper())
            {
                case "PL":
                    data = data.Where(r => r.To == "PL").ToList();
                    break;
                case "PR":
                    data = data.Where(r => r.To == "PR").ToList();
                    break;
                case "MX":
                    data = data.Where(r => r.To == "MX").ToList();
                    break;
                case "CA":
                    data = data.Where(r => r.To == "CA").ToList();
                    break;
                case "US":
                    data = data.Where(r => r.To == "US").ToList();
                    break;
                default:
                    data = data.Where(r => r.To == "ANY").ToList();
                    break;
            }

            return data;
        }

    }
}
