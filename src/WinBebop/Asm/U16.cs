﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinBebop.Asm
{
   public class U16:UInt
   {
      private ushort _value;

      public U16(ushort value):base(2)
      {
         _value = value;
      }

      public ushort Read()
      {
         return _value;
      }

   }
}