namespace Discord
{
    /// <summary>
    ///     Represents a Discord attachment.
    /// </summary>
    public interface IAttachment
    {
        /// <summary>
        ///     Gets the ID of this attachment.
        /// </summary>
        /// <returns>
        ///     A snowflake ID associated with this attachment.
        /// </returns>
        ulong Id { get; }

        /// <summary>
        ///     Gets the filename of this attachment.
        /// </summary>
        /// <returns>
        ///     A string containing the full filename of this attachment (e.g. textFile.txt).
        /// </returns>
        string Filename { get; }
        /// <summary>
        ///     Gets the URL of this attachment.
        /// </summary>
        /// <returns>
        ///     A string containing the URL of this attachment.
        /// </returns>
        string Url { get; }
        /// <summary>
        ///     Gets a proxied URL of this attachment.
        /// </summary>
        /// <returns>
        ///     A string containing the proxied URL of this attachment.
        /// </returns>
        string ProxyUrl { get; }
        /// <summary>
        ///     Gets the file size of this attachment.
        /// </summary>
        /// <returns>
        ///     The size of this attachment in bytes.
        /// </returns>
        int Size { get; }
        /// <summary>
        ///     Gets the height of this attachment.
        /// </summary>
        /// <returns>
        ///     The height of this attachment if it is a picture; otherwise <see langword="null"/>.
        /// </returns>
        int? Height { get; }
        /// <summary>
        ///     Gets the width of this attachment.
        /// </summary>
        /// <returns>
        ///     The width of this attachment if it is a picture; otherwise <see langword="null"/>.
        /// </returns>
        int? Width { get; }
    }
}
