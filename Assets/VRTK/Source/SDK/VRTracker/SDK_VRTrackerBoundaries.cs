// VRTracker Boundaries|SDK_VRTracker|005
namespace VRTK
{
    using UnityEngine;

    /// <summary>
    /// The Oculus Boundaries SDK script provides a bridge to the Oculus SDK play area.
    /// </summary>
	[SDK_Description(typeof(SDK_VRTrackerSystem))]
    [SDK_Description(typeof(SDK_VRTrackerSystem), 1)]
    [SDK_Description(typeof(SDK_VRTrackerSystem), 2)]
    [SDK_Description(typeof(SDK_VRTrackerSystem), 3)]
    [SDK_Description(typeof(SDK_VRTrackerSystem), 4)]
    [SDK_Description(typeof(SDK_VRTrackerSystem), 5)]
    [SDK_Description(typeof(SDK_VRTrackerSystem), 6)]
    public class SDK_VRTrackerBoundaries
#if VRTK_DEFINE_SDK_VRTRACKER
        : SDK_BaseBoundaries
#else
        : SDK_FallbackBoundaries
#endif
    {
#if VRTK_DEFINE_SDK_VRTRACKER
        /// <summary>
        /// The InitBoundaries method is run on start of scene and can be used to initialse anything on game start.
        /// </summary>
        public override void InitBoundaries()
        {

        }

        /// <summary>
        /// The GetPlayArea method returns the Transform of the object that is used to represent the play area in the scene.
        /// </summary>
        /// <returns>A transform of the object representing the play area in the scene.</returns>
        public override Transform GetPlayArea()
        {
            cachedPlayArea = GetSDKManagerPlayArea();
            if (cachedPlayArea == null)
            {
                GameObject foundCameraRig = VRTK_SharedMethods.FindEvenInactiveGameObject<SDK_VRTrackerCameraRig>(null, true);
                if (foundCameraRig != null)
                {
                    cachedPlayArea = foundCameraRig.transform;
                }
            }

            return cachedPlayArea;
        }

        /// <summary>
        /// The GetPlayAreaVertices method returns the points of the play area boundaries.
        /// </summary>
        /// <returns>A Vector3 array of the points in the scene that represent the play area boundaries.</returns>
        public override Vector3[] GetPlayAreaVertices()
        {
            return null;
        }

        /// <summary>
        /// The GetPlayAreaBorderThickness returns the thickness of the drawn border for the given play area.
        /// </summary>
        /// <returns>The thickness of the drawn border.</returns>
        public override float GetPlayAreaBorderThickness()
        {
            return 0.1f;
        }

        /// <summary>
        /// The IsPlayAreaSizeCalibrated method returns whether the given play area size has been auto calibrated by external sensors.
        /// </summary>
        /// <returns>Returns true if the play area size has been auto calibrated and set by external sensors.</returns>
        public override bool IsPlayAreaSizeCalibrated()
        {
            return true;
        }

        /// <summary>
        /// The GetDrawAtRuntime method returns whether the given play area drawn border is being displayed.
        /// </summary>
        /// <returns>Returns true if the drawn border is being displayed.</returns>
        public override bool GetDrawAtRuntime()
        {
            return false;
        }

        /// <summary>
        /// The SetDrawAtRuntime method sets whether the given play area drawn border should be displayed at runtime.
        /// </summary>
        /// <param name="value">The state of whether the drawn border should be displayed or not.</param>
        public override void SetDrawAtRuntime(bool value)
        {
        }
        #endif
    }
}