using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JC.Feedback
{
    public class ParticleEffect : Feedback
    {
        #region Fields

        [SerializeField]
        private ParticleSystem particle;

        #endregion

        #region Overrides

        public override void Play()
        {
            base.Play();

            var particleFX = Instantiate(particle, this.transform);
        }

        #endregion
    }
}

