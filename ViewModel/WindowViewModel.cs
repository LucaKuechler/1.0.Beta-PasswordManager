using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Password_Manager
{
    class WindowViewModel : BaseViewModel
    {
        #region Private Member
        ///<summary>
        ///The window this view model controls
        /// </summary>
        public Window MainWindow;

        // Window Options
        private double MainOuterMarginSize = 10.0;
        #endregion

        #region Public Properties
        public double WindowMaxWidth { get; set; } = 1100;
        public double WindowMaxHeight { get; set; } = 650;
        public double WindowMinWidth { get; set; } = 1100;
        public double WindowMinHeight { get; set; } = 650;


        public double ResizeBorder { get; set; } = 6.0;

        public Thickness ResizeBorderThickness { get { return new Thickness(ResizeBorder + OuterMarginSize); } }

        public Thickness InnerContentPadding { get { return new Thickness(ResizeBorder); } }

        //Max Window Problem even if i dont include the feature
        public double OuterMarginSize
        {
            get
            {
                return MainWindow.WindowState == WindowState.Maximized ? 0 : MainOuterMarginSize;
            }
            set
            {
                MainOuterMarginSize = value;
            }
        }

        // fix distance to edge of windows
        public Thickness OuterMarginSizeThickness { get { return new Thickness(OuterMarginSize + 1); } }

        //set height of header
        public double TitleHeight { get; set; } = 25.0;

        public GridLength TitleHeightLengthGrid { get { return new GridLength(TitleHeight + ResizeBorder); }}

        // current Page of application
        public ApplicationPage CurrentPage { get; set; } = ApplicationPage.Login;
        

        #endregion

        #region Commands
        public ICommand MinimizeCommand { get; set; }
        public ICommand MaximizeCommand { get; set; }
        public ICommand CloseCommand { get; set; }
        public ICommand MenuCommand { get; set; }
        #endregion

        #region Constructor

        ///<summary>
        /// DF constructor
        /// </summary>
        public WindowViewModel(Window window)
        {
            MainWindow = window;

            MainWindow.StateChanged += (sender, e) =>
            {
                // fire off when Resize
                OnPropertyChanged(nameof(ResizeBorderThickness));
                OnPropertyChanged(nameof(OuterMarginSize));
                OnPropertyChanged(nameof(OuterMarginSizeThickness));
            };

            // create commands
            MinimizeCommand = new RelayCommand(() => MainWindow.WindowState = WindowState.Minimized);
            
            // need to add ^ Thing because if window is max it goes back to normal so ^ acts like a kind of if statement
            MaximizeCommand = new RelayCommand(() => MainWindow.WindowState ^= WindowState.Maximized);

            CloseCommand = new RelayCommand(() => MainWindow.Close());

            MenuCommand = new RelayCommand(() => SystemCommands.ShowSystemMenu(MainWindow, GetMousePosition()));

            var resizer = new WindowResizer(MainWindow);
        }

        #endregion
        #region Mouse
        private Point GetMousePosition()
        {
            var position = Mouse.GetPosition(MainWindow);

            return new Point(position.X + MainWindow.Left, position.Y + MainWindow.Top);
        }

        #endregion
    }
}
