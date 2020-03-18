﻿using JT808.Protocol.Interfaces;
using JT808.Protocol.MessagePack;
using System;
using System.Collections.Generic;
using System.Text;

namespace JT808.Protocol.MessageBody.Recorder
{
    /// <summary>
    /// 记录仪数据体
    /// </summary>
    public abstract class JT808_RecorderBody : IJT808Description
    {
        /// <summary>
        /// 命令字
        /// </summary>
        public abstract byte CommandId { get; }
        public abstract JT808_RecorderBody Deserialize(ref JT808MessagePackReader reader, IJT808Config config);
        public abstract void Serialize(ref JT808MessagePackWriter writer, JT808_RecorderBody value, IJT808Config config);
        /// <summary>
        /// 跳过数据体序列化
        /// 默认不跳过
        /// 当数据体为空的时候，使用null作为空包感觉不适合，所以就算使用空包也需要new一下来表达意思。
        /// </summary>
        public virtual bool SkipSerialization { get; set; } = false;

        public abstract string Description { get; }
    }
}
