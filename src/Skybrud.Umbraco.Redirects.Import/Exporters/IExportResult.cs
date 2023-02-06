﻿using System;

namespace Skybrud.Umbraco.Redirects.Import.Exporters {

    /// <summary>
    /// Interface describing the result of an export.
    /// </summary>
    public interface IExportResult {

        /// <summary>
        /// Gets the unique key of the export result.
        /// </summary>
        Guid Key { get; }

        /// <summary>
        /// Gets the content type of the file generated by the result.
        /// </summary>
        string ContentType { get; }

        /// <summary>
        /// Gets the file name of the file generated by the result.
        /// </summary>
        string FileName { get; }

        /// <summary>
        /// Returns the bytes of the exported file.
        /// </summary>
        /// <param name="options">The export options.</param>
        /// <returns>An array of <see cref="byte"/>.</returns>
        byte[] GetBytes(IExportOptions options);

    }

}