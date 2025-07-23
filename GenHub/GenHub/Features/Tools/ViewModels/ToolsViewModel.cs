using CommunityToolkit.Mvvm.ComponentModel;
using System.Threading.Tasks;
using GenHub.Common.ViewModels;

namespace GenHub.Features.Tools.ViewModels;

/// <summary>
/// ViewModel for the Tools tab.
/// </summary>
public partial class ToolsViewModel : ViewModelBase
{
    [ObservableProperty]
    private string _title = "Tools";

    /// <summary>
    /// Initializes a new instance of the <see cref="ToolsViewModel"/> class.
    /// </summary>
    public ToolsViewModel()
    {
    }

    /// <summary>
    /// Asynchronously initializes the view model.
    /// </summary>
    /// <returns>A completed <see cref="Task"/>.</returns>
    public virtual Task InitializeAsync() => Task.CompletedTask;
}