namespace ZonyLrcTools.Cli.Infrastructure
{
    /// <summary>
    /// 歌曲信息的承载类，携带歌曲的相关数据。
    /// </summary>
    public class MusicInfo
    {
        /// <summary>
        /// 歌曲对应的物理文件路径。
        /// </summary>
        public string FilePath { get; }

        /// <summary>
        /// 歌曲的名称。
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// 歌曲的作者。
        /// </summary>
        public string Artist { get; }

        /// <summary>
        /// 构建一个新的 <see cref="MusicInfo"/> 对象。
        /// </summary>
        /// <param name="filePath">歌曲对应的物理文件路径。</param>
        /// <param name="name">歌曲的名称。</param>
        /// <param name="artist">歌曲的作者。</param>
        public MusicInfo(string filePath, string name, string artist)
        {
            FilePath = filePath;
            Name = name;
            Artist = artist;
        }
    }
}