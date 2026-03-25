# Design Patterns: MVC, MVP and MVVM

A comprehensive guide to understanding and implementing the three most popular architectural patterns for building maintainable, testable, and scalable applications.

## 📋 Table of Contents
- [Overview](#overview)
- [Comparison Matrix](#comparison-matrix)
- [Big Picture Comparison](#big-picture-comparison)
- [When to Use Which Pattern](#when-to-use-which-pattern)
- [References](#references)

## Overview

These architectural patterns separate concerns in an application, making it easier to maintain, test, and extend. Each pattern organizes code into three main components:

| Pattern | Components | Primary Focus |
|---------|------------|---------------|
| MVC | Model, View, Controller | Web applications, traditional desktop |
| MVP (Passive View) | Model, View, Presenter |  Traditional UI frameworks like .NET (WinForms, WPF) and Java Swing  UI systems often mix UI and logic by default. <br /> Passive View helps enforce clean separation and the UI should be as “dumb” as possible meanwhile all behavior lives in a controller/presenter.  |
| MVP (Classic) <br /> <br /><font size="5">*often called "Supervising Controller"</font>| Model, View, Presenter | Desktop applications, Android |
| Presentation Model <br /><br /> <font size="5">*known as MVVM (Model, View, ViewModel) which uses the name “ViewModel” to refer to the presentation model element of the pattern </font> | Model, View, ViewModel | Modern UI frameworks (WPF, Xamarin, Blazor) |

## Code
### MVP (Passive View) x MVP (Classic)
#### MVP (Passive View)
| Pattern | Components | Primary Focus |
|---------|------------|---------------|
| 1 | 2 | 3 |

## Comparison Matrix

| Pattern | Benefits | Drawbacks |
|---------|----------|-----------|
| **MVC**<br/>*(Model-View-Controller)* | • **Separation of Concerns**: Clear division between data, UI, and business logic<br/>• **Testability**: Controllers can be unit tested independently<br/>• **Scalability**: Handles complex applications well<br/>• **Framework Support**: Many frameworks support MVC out-of-the-box (ASP.NET, Rails, Spring)<br/>• **Reusability**: Models can be reused across different views<br/>• **Parallel Development**: Teams can work on different components simultaneously | • **Complexity**: Can become complex for large applications with many views<br/>• **Tight Coupling**: Views and controllers are often tightly coupled<br/>• **Testing UI**: View logic is difficult to unit test<br/>• **Controller Bloat**: Controllers can become "God Objects" with too much logic<br/>• **Multiple Entry Points**: Multiple controllers can access the same model causing inconsistencies<br/>• **View State Management**: Managing state across views can be challenging |
| **MVP**<br/>*(Model-View-Presenter)* | • **Enhanced Testability**: Presenters can be tested without UI framework<br/>• **Clear Separation**: View is completely passive, containing only UI logic<br/>• **Flexibility**: Can work with any UI technology (Windows Forms, Android, Web)<br/>• **Easier Debugging**: Business logic is centralized in presenter<br/>• **Better State Management**: Presenter manages view state explicitly<br/>• **Mockable Views**: Views can be mocked for unit testing<br/>• **Code Reusability**: Presenters can be reused with different view implementations | • **More Code**: Requires more boilerplate code than MVC<br/>• **Steep Learning Curve**: Developers need to understand the passive view concept<br/>• **Presenter Bloat**: Presenters can become large with complex UI logic<br/>• **Manual Data Binding**: Often requires manual data synchronization between view and presenter<br/>• **Maintenance Overhead**: Every view needs a corresponding presenter<br/>• **Event Handling**: Complex event handling between view and presenter |
| **MVVM**<br/>*(Model-View-ViewModel)* | • **Data Binding**: Automatic UI synchronization via two-way data binding<br/>• **Maximum Testability**: ViewModels are easily unit tested<br/>• **Declarative UI**: UI behavior defined declaratively in XAML/HTML<br/>• **Reduced Boilerplate**: Less code needed for UI updates<br/>• **Separation**: View contains only visual elements, no logic<br/>• **State Management**: ViewModel maintains state independent of view<br/>• **Designer-Friendly**: Developers and designers can work simultaneously<br/>• **Commands**: Encapsulates user actions in reusable commands | • **Complex Data Binding**: Debugging binding errors can be difficult<br/>• **Performance**: Heavy data binding can impact performance<br/>• **Memory Leaks**: Improper binding cleanup can cause memory leaks<br/>• **Learning Curve**: Requires understanding of INotifyPropertyChanged, commands, and data binding<br/>• **Tooling Dependency**: Works best with frameworks like WPF, Xamarin, or Blazor<br/>• **Over-Engineering**: Simple applications may be over-engineered<br/>• **Refactoring**: Binding paths break easily when refactoring properties |

## Big Picture Comparison
| Pattern | Who handles logic? | How “smart” is the View? | Best for |
|---------|------------|---------------|---------------|
| MVC | Controller + Model | Medium | Web apps, simple apps |
| MVP (Passive View) | Presenter | Very dumb | Enterprise, test-heavy apps |
| Classic MVP | Presenter | Slightly aware | UI-heavy desktop apps |
| MVVM | Presenter | Slightly aware | UI-heavy desktop apps |

## When to Use Which Pattern
| Choose MVC When | Choose MVP When | Choose MVVM When |
|---------|------------|---------------|
| Building web applications (ASP.NET Core, Spring, Rails) | Building desktop applications (Windows Forms, WPF | Building modern UI applications with data binding support (WPF, Xamarin, MAUI, Blazor) |
| Working with frameworks that have built-in MVC support | Developing Android applications | You want to leverage declarative UI (XAML, Razor) |
| You need a simple, straightforward architecture | You need maximum testability of business logic | Maximum separation between UI and logic is required |
| Your application has a relatively simple UI | You want explicit control over view updates | Working with frameworks that support INotifyPropertyChanged |
| You want to leverage convention-over-configuration | Working with UI frameworks that don't support data binding well | You have a dedicated designer/developer workflow |
|  | You need to mock views for testing | Building complex, data-intensive applications |


## References
[Microsoft MVP Pattern Documentation](https://learn.microsoft.com/en-us/archive/msdn-magazine/2006/august/design-patterns-model-view-presenter)

[Microsoft MVVM Pattern](https://docs.microsoft.com/en-us/dotnet/architecture/maui/mvvm)

[ASP.NET Core MVC](https://docs.microsoft.com/en-us/aspnet/core/mvc/overview)

[Martin Fowler's GUI Architectures](https://www.martinfowler.com/eaaDev/uiArchs.html)

[Martin Fowler's Passive View](https://martinfowler.com/eaaDev/PassiveScreen.html)

[Martin Fowler's Presentation Model](https://martinfowler.com/eaaDev/PresentationModel.html)

[Martin Fowler's Supervising Controller](View https://martinfowler.com/eaaDev/SupervisingPresenter.html)

## License
MIT
 
