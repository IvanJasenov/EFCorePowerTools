﻿namespace EFCorePowerTools.Shared.Models
{
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using Annotations;

    /// <summary>
    /// A model holding the data of EF Core modeling options.
    /// </summary>
    public class ModelingOptionsModel : INotifyPropertyChanged
    {
        private bool _installNuGetPackage;
        private int _selectedToBeGenerated;
        private bool _includeConnectionString;
        private bool _useHandelbars;
        private int _selectedHandlebarsLanguage;
        private bool _usePluralizer;
        private bool _useDatabaseNames;
        private string _ns;
        private string _outputPath;
        private string _outputContextPath;
        private string _modelNamespace;
        private string _contextNamespace;
        private string _modelName;
        private bool _useDataAnnotations;
        private string _projectName;
        private string _dacpacPath;
        private bool _useDbContextSplitting;
        private bool _useStoreProcedures;
        private bool _mapSpatialTypes;
        private bool _mapNodaTimeTypes;
        private bool _useEf6Pluralizer;

        public bool UseDataAnnotations
        {
            get => _useDataAnnotations;
            set
            {
                if (value == _useDataAnnotations) return;
                _useDataAnnotations = value;
                OnPropertyChanged();
            }
        }

        public bool UseStoredProcedures
        {
            get => _useStoreProcedures;
            set
            {
                if (value == _useStoreProcedures) return;
                _useStoreProcedures = value;
                OnPropertyChanged();
            }
        }

        public string ModelName
        {
            get => _modelName;
            set
            {
                if (value == _modelName) return;
                _modelName = value;
                OnPropertyChanged();
            }
        }

        public string OutputPath
        {
            get => _outputPath;
            set
            {
                if (value == _outputPath) return;
                _outputPath = value;
                OnPropertyChanged();
            }
        }

        public string OutputContextPath
        {
            get => _outputContextPath;
            set
            {
                if (value == _outputContextPath) return;
                _outputContextPath = value;
                OnPropertyChanged();
            }
        }

        public string ModelNamespace
        {
            get => _modelNamespace;
            set
            {
                if (value == _modelNamespace) return;
                _modelNamespace = value;
                OnPropertyChanged();
            }
        }

        public string ContextNamespace
        {
            get => _contextNamespace;
            set
            {
                if (value == _contextNamespace) return;
                _contextNamespace = value;
                OnPropertyChanged();
            }
        }

        public string Namespace
        {
            get => _ns;
            set
            {
                if (value == _ns) return;
                _ns = value;
                OnPropertyChanged();
            }
        }

        public bool UseDatabaseNames
        {
            get => _useDatabaseNames;
            set
            {
                if (value == _useDatabaseNames) return;
                _useDatabaseNames = value;
                OnPropertyChanged();
            }
        }

        public bool UsePluralizer
        {
            get => _usePluralizer;
            set
            {
                if (value == _usePluralizer) return;
                _usePluralizer = value;
                OnPropertyChanged();
            }
        }

        public bool UseDbContextSplitting
        {
            get => _useDbContextSplitting;
            set
            {
                if (value == _useDbContextSplitting) return;
                _useDbContextSplitting = value;
                OnPropertyChanged();
            }
        }

        public bool UseHandelbars
        {
            get => _useHandelbars;
            set
            {
                if (value == _useHandelbars) return;
                _useHandelbars = value;
                OnPropertyChanged();
            }
        }

        public int SelectedHandlebarsLanguage
        {
            get => _selectedHandlebarsLanguage;
            set
            {
                if (value == _selectedHandlebarsLanguage) return;
                _selectedHandlebarsLanguage = value;
                OnPropertyChanged();
            }
        }

        public bool IncludeConnectionString
        {
            get => _includeConnectionString;
            set
            {
                if (value == _includeConnectionString) return;
                _includeConnectionString = value;
                OnPropertyChanged();
            }
        }

        public int SelectedToBeGenerated
        {
            get => _selectedToBeGenerated;
            set
            {
                if (value == _selectedToBeGenerated) return;
                _selectedToBeGenerated = value;
                OnPropertyChanged();
            }
        }

        public bool InstallNuGetPackage
        {
            get => _installNuGetPackage;
            set
            {
                if (value == _installNuGetPackage) return;
                _installNuGetPackage = value;
                OnPropertyChanged();
            }
        }

        public string ProjectName
        {
            get => _projectName;
            set
            {
                if (value == _projectName) return;
                _projectName = value;
                OnPropertyChanged();
            }
        }

        public string DacpacPath
        {
            get => _dacpacPath;
            set
            {
                if (value == _dacpacPath) return;
                _dacpacPath = value;
                OnPropertyChanged();
            }
        }

        public bool MapSpatialTypes
        {
            get => _mapSpatialTypes;
            set
            {
                if (value == _mapSpatialTypes) return;
                _mapSpatialTypes = value;
                OnPropertyChanged();
            }
        }

        public bool MapNodaTimeTypes
        {
            get => _mapNodaTimeTypes;
            set
            {
                if (value == _mapNodaTimeTypes) return;
                _mapNodaTimeTypes = value;
                OnPropertyChanged();
            }
        }

        public bool UseEf6Pluralizer
        {
            get => _useEf6Pluralizer;
            set
            {
                if (value == _useEf6Pluralizer) return;
                _useEf6Pluralizer = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}