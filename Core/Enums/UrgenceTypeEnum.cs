using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Enums
{
    public enum UrgenceTypeEnum
    {
        /// <summary>
        /// Urgence non spécifiée.
        /// </summary>
        [StringValue("Non renseigné")]
        NonRenseigne = 0,
        /// <summary>
        /// Examen urgent.
        /// </summary>
        [StringValue("Urgent")]
        Urgent = 1,
        /// <summary>
        /// Examen à réaliser au plus vite.
        /// </summary>
        [StringValue("Rapidement")]
        Rapidement = 2,
        /// <summary>
        /// Examen à planifier à plus long terme.
        /// </summary>
        [StringValue("A planifier")]
        APlanifier = 3,
    }
}
