﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AutoCadTestDemo.Bussiness
{
    public static class TaskFactroy
    {
        public static AbstractTask CreateTaskByType(TaskType type)
        {
            if (type == TaskType.DefaultTask)
                return new DefaultTask();

            return null;
        }
    }
}
