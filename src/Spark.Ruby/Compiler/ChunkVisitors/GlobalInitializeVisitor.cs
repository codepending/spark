// Copyright 2008-2009 Louis DeJardin - http://whereslou.com
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// 
using Spark.Compiler;
using Spark.Compiler.ChunkVisitors;

namespace Spark.Ruby.Compiler.ChunkVisitors
{
    public class GlobalInitializeVisitor : ChunkVisitor
    {
        private readonly SourceWriter _source;

        public GlobalInitializeVisitor(SourceWriter sourceWriter)
        {
            _source = sourceWriter;
        }

        protected override void Visit(GlobalVariableChunk chunk)
        {
            _source.Write("@").Write(chunk.Name).Write("=").WriteLine(chunk.Value);
        }
    }
}