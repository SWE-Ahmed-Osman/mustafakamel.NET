using Fathy.Common.Startup;
using Portfolio.Dashboard.Get.DTOs;

namespace Portfolio.Dashboard.Get.Repositories;

public interface IGetDashboardRepository
{
    Task<Response<DashboardPageDto>> IndexAsync();
}