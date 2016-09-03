﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Pihrtsoft.Snippets.Comparers;

namespace Pihrtsoft.Snippets
{
    /// <summary>
    /// Represents the set of shortcuts.
    /// </summary>
    public class ShortcutCollection
        : Collection<string>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShortcutCollection"/> class that is empty.
        /// </summary>
        public ShortcutCollection()
            : base(new List<string>())
        {
        }

        /// <summary>
        /// Sorts the elements in the entire <see cref="ShortcutCollection"/> using the <see cref="StringComparer.InvariantCulture"/> comparer.
        /// </summary>
        public void Sort()
        {
            Sort(Comparer.StringComparer);
        }

        /// <summary>
        /// Sorts the elements in the entire <see cref="ShortcutCollection"/> using the specified comparer.
        /// </summary>
        /// <param name="comparer">The <see cref="IComparer{String}"/> implementation to use when comparing elements.</param>
        public void Sort(IComparer<string> comparer)
        {
            ((List<string>)Items).Sort(comparer);
        }
    }
}
