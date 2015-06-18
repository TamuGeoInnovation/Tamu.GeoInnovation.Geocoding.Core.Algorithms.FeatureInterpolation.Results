using System;
using System.Xml.Serialization;
using USC.GISResearchLab.Common.Geometries;
using USC.GISResearchLab.Geocoding.Core.Metadata.FeatureInterpolationResults;
using USC.GISResearchLab.Geocoding.Core.OutputData.Error;

namespace USC.GISResearchLab.Geocoding.Core.Algorithms.FeatureInterpolationMethods
{
    public class FeatureInterpolationResult
    {
        #region Properties

        public Geometry Geometry { get; set; }
        public GeocodedError GeocodedError { get; set; }

        public FeatureInterpolationResultType FeatureInterpolationResultType { get; set; }

        public string Error { get; set; }

        [XmlIgnore]
        public Exception Exception { get; set; }
        public bool ExceptionOccurred { get; set; }

        public FeatureInterpolationResult()
        {
            GeocodedError = new GeocodedError();
        }

        #endregion
    }
}
