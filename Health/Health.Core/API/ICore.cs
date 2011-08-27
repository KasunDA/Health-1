﻿namespace Health.Core.API
{
    /// <summary>
    /// Интерфейс регламентирует оющий функционал для сервисов и репозиториев.
    /// </summary>
    public interface ICore
    {
        /// <summary>
        /// Логгер.
        /// </summary>
        ILogger Logger { get; set; }

        /// <summary>
        /// DI ядро.
        /// </summary>
        IDIKernel DIKernel { get; set; }

        /// <summary>
        /// Центральное ядро системы.
        /// </summary>
        ICoreKernel CoreKernel { get; set; }
    }
}