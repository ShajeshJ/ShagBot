﻿using Amazon.DynamoDBv2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwsDB.Models
{
    public interface IAwsDbItem
    {
        string GetIdFieldName();
    }
}
