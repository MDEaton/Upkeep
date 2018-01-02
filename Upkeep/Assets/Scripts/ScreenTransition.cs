using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenTransition : MonoBehaviour {

    public ScreenManager.ScreenStates StateToReturnTo = ScreenManager.ScreenStates.Kingdom;

	public void GoTo ()
    {
        ScreenManager.Instance.ChangeScreen(StateToReturnTo);
    }
}
