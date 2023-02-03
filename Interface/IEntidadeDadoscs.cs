﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioAlterdata.Interface
{
    interface IEntidadeDados
    {
        public DateTime CreatedAt { get; set; }
        public string Name { get; set; }

        public string Avatar { get; set; }

        public string Squad { get; set; }

        public string Login { get; set; }

        public string Email { get; set; }

        public string Id { get; set; }

        public string StatusCode { get; set; }

    }
}
