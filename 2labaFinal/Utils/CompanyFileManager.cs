using _2labaFinal.Models;
using _2labaFinal.Models.Company;
using _2labaFinal.Models.DTO;
using _2labaFinal.Models.Machine;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2labaFinal.Utils
{
    public static class CompanyFileManager
    {
        public static void SaveCompany(WaterProvider waterProvider, string filePath)
        {
            string json = JsonSerializer.Serialize(waterProvider);
            File.WriteAllText(filePath, json);
        }

        public static WaterProvider LoadCompany(string filePath)
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                var dto =  JsonSerializer.Deserialize<CompanyDTO>(json);
                var provider = new WaterProvider(
                    dto.Name,
                    dto.Address,
                    dto.ID,
                    dto.Tanks
                );
                provider.Machines = dto.Machines
                .ConvertAll(m => {
                    var wm = new WaterMachine(
                         m._stillWaterPrice,
                         m._sodaWaterPrice,
                         dto.MaxTankVolume,
                         m.BottleCount,
                         m.Address,
                         0
                         );
                    wm.Income = m.Income;
                    return wm;
                    }
                );
                return provider;
            }
            else
            {
                throw new Exception("File not found!");
            }
        }
    }
}
