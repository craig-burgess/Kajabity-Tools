﻿/*
 * Copyright 2009-15 Williams Technologies Limtied.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 * Kajbity is a trademark of Williams Technologies Limited.
 *
 * http://www.kajabity.com
 */

using Kajabity.Tools.Forms;

namespace CsvEditor
{
    public class CsvDocument : Document
    {

        private string[][] rows = null;
        public string[][] Rows
        {
            get
            {
                return rows;
            }
            set
            {
                rows = value;
                Modified = true;
            }
        }
        
        public CsvDocument()
        {
        }

        public CsvDocument( string name )
        {
        }

        public CsvDocument( string name, string[][] records )
            : base( name )
        {
            rows = records;
        }
    }
}
