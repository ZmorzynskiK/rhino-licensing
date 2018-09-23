using Caliburn.PresentationFramework.Screens;
using Rhino.Licensing.AdminTool.Model;

namespace Rhino.Licensing.AdminTool.ViewModels
{
    public class LicenseInfoViewModel : Screen, ILicenseInfoViewModel
    {
        private License _currentLicense;

        public virtual License CurrentLicense
        {
            get { return _currentLicense; }
            set
            {
                _currentLicense = value;
                NotifyOfPropertyChange(() => CurrentLicense);
				NotifyOfPropertyChange(() => CurrentLicenseHWID);
            }
        }

		public virtual string CurrentLicenseHWID
		{
			get
			{
				if(_currentLicense == null)
					return "";
				foreach(var userData in _currentLicense.Data)
				{
					if(userData.Key.Equals(Extensions.LicenseExtensions.HWIDUserDataKey, System.StringComparison.OrdinalIgnoreCase))
						return userData.Value;
				}
				return "";
			}
			set
			{
				if(_currentLicense == null)
					return;
				for(int i = 0; i < _currentLicense.Data.Count; ++i)
				{
					var ud = _currentLicense.Data[i];
					if(ud.Key.Equals(Extensions.LicenseExtensions.HWIDUserDataKey, System.StringComparison.OrdinalIgnoreCase))
					{
						ud.Value = value;
						_currentLicense.Data[i] = ud;
						return;
					}
				}
				// add new user data
				_currentLicense.Data.Add(new UserData()
				{
					Key = Extensions.LicenseExtensions.HWIDUserDataKey,
					Value = value
				});
			}
		}

	}
}