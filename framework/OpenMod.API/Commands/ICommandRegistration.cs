﻿using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using OpenMod.API.Prioritization;

namespace OpenMod.API.Commands
{
    public interface ICommandRegistration
    {
        /// <summary>
        ///     The owner component of the command
        /// </summary>
        IOpenModComponent Component { get; }

        /// <summary>
        ///     <para>The primary name of the command, which will be used to execute it.</para>
        ///     <para>The primary name overrides any <see cref="Aliases">aliases</see> of other commands by default.</para>
        ///     <para>
        ///         <b>This property must never return null.</b>
        ///     </para>
        /// </summary>
        /// <example>
        ///     If the name is "Help", the command will be usually be called using "/heal" (or just "heal" in console)
        /// </example>
        string Name { get; }

        /// <summary>
        ///     <para>The aliases of the command, which are often shorter versions of the primary name.</para>
        ///     <para>
        ///         <b>This property can return null.</b>
        ///     </para>
        /// </summary>
        /// <example>
        ///     If the aliases are "h" and "he", the command will be callable using "/h" or "/he".
        /// </example>
        [CanBeNull]
        IReadOnlyCollection<string> Aliases { get; }

        /// <summary>
        ///     The full description of the command.
        ///     <para>
        ///         <b>This proprty can return null</b>.
        ///     </para>
        /// </summary>
        [CanBeNull]
        string Description { get; }

        /// <summary>
        ///     The command syntax will be shown to the <see cref="IUser" /> when the command was not used correctly.
        ///     <para>An output for the above example could be "/heal [player] &lt;amount&gt;".</para>
        ///     <para>The syntax should not contain Child Command usage.</para>
        ///     <para>
        ///         <b>This property must never return null.</b>
        ///     </para>
        /// </summary>
        /// <remarks>
        ///     [...] means optional argument and &lt;...&gt; means required argument, so in this case "player" is an optional
        ///     argument while "amount" is a required one.
        /// </remarks>
        /// <example>
        ///     <c>"[player] &lt;amount&gt;"</c>
        /// </example>
        ///
        [CanBeNull]
        string Syntax { get; }

        string Id { get; }

        Priority Priority { get; set; }

        [CanBeNull]
        string ParentId { get; set; }

        bool SupportsActor(ICommandActor actor);
        
        ICommand Instantiate(IServiceProvider serviceProvider);
    }
}