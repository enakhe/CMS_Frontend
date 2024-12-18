using CMS_Frontend.Models;
using CommunityToolkit.Mvvm.Input;

namespace CMS_Frontend.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}