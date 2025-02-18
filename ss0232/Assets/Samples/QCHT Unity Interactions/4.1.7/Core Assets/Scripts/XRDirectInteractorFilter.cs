// /******************************************************************************
//  * File: XRDirectInteractorFilter.cs
//  * Copyright (c) 2023 Qualcomm Technologies, Inc. and/or its subsidiaries. All rights reserved.
//  *
//  *
//  ******************************************************************************/

using UnityEngine;


namespace QCHT.Interactions.Distal
{
    public class XRDirectInteractorFilter : MonoBehaviour, IXRRayInteractorFilter
    {
        [SerializeField] public UnityEngine.XR.Interaction.Toolkit.Interactors.XRDirectInteractor directInteractor;
         
        public bool CanShowRay => directInteractor == null || !directInteractor.hasHover;
    }
}