﻿using Sino.JobExecutor.Biz.Model;
using System.Threading.Tasks;

namespace Sino.JobExecutor.Job
{
    /// <summary>
    /// 任务需要实现的接口
    /// </summary>
    public interface IJobHandler
    {
        Task<ReturnT<string>> Execute(JobExecuteContext context);
    }
}
