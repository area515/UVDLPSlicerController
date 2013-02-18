﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace UV_DLP_3D_Printer
{
    /*
     * This class holds some information about the 
     * slicing and building parameters
     */
    public class SliceBuildConfig
    {
        public double dpmmX; // dots per mm x
        public double dpmmY; // dots per mm y
        public int xres, yres; // the resolution of the output image in pixels
        public double ZThick; // thickness of the z layer - slicing height
        public int layertime_ms; // time to project image per layer in milliseconds
        public int plat_temp; // desired platform temperature in celsius 
        public bool exportgcode; // export the gcode file when slicing
        public bool exportsvg; // export the svg slices when building
        public bool exportimages; // export image slices when building
        private String m_headercode; // inserted at beginning of file
        private String m_footercode; // inserted at end of file
        private String m_perslicecode; // inserted between each slice

        private String[] m_defheader = 
        {
            "(********** Header Start ********)\r\n", // 
            "(Generated by UV - DLP Slicer)\r\n",
            "G21 (Set units to be mm)\r\n", 
            "G90 (Absolute Positioning)\r\n",
            "M17 (Enable motors)\r\n",
            "(********** Header End **********)\r\n", // 
            //"()\r\n"
        };
        private String[] m_deffooter = 
        {
            "(********** Footer Start ********)\r\n", // 
            "G28 Z (Home to Z axis Maximum)\r\n",
            "(<Completed>)\r\n", // a marker for completed            
            "(********** Footer End ********)\r\n", // 
        };

        private String[] m_defperslice = 
        {
            "\r\n"
        };
        private void SetDefaultCodes()
        {
            StringBuilder sb = new StringBuilder();
            foreach (String s in m_defheader)
                sb.Append(s);
            HeaderCode = sb.ToString();

            sb = new StringBuilder(); // clear
            foreach (String s in m_deffooter)
                sb.Append(s);
            FooterCode = sb.ToString();

            sb = new StringBuilder();
            foreach (String s in m_defperslice)
                sb.Append(s);
            PerSliceCode = sb.ToString();
        }
        public String HeaderCode
        {
            get { return m_headercode; }
            set { m_headercode = value; }
        }
        public String FooterCode
        {
            get { return m_footercode; }
            set { m_footercode = value; }
        }
        public String PerSliceCode
        {
            get { return m_perslicecode; }
            set { m_perslicecode = value; }
        }

        /*
         Copy constructor
         */
        public SliceBuildConfig(SliceBuildConfig source) 
        {
            dpmmX = source.dpmmX; // dots per mm x
            dpmmY = source.dpmmY; // dots per mm y
            xres = source.xres;
            yres = source.yres; // the resolution of the output image
            ZThick = source.ZThick; // thickness of the z layer - slicing height
            layertime_ms = source.layertime_ms; // time to project image per layer in milliseconds
            plat_temp = source.plat_temp; // desired platform temperature in celsius 
            exportgcode = source.exportgcode; // export the gcode file when slicing
            exportsvg = source.exportsvg; // export the svg slices when building
            exportimages = source.exportimages; // export image slices when building
            m_headercode = source.m_headercode; // inserted at beginning of file
            m_footercode = source.m_footercode; // inserted at end of file
            m_perslicecode = source.m_perslicecode; // inserted between each slice            
        }

        public SliceBuildConfig() 
        {
            layertime_ms = 5000;// 5 seconds default
            CreateDefault();
        }
        public void UpdateFrom(MachineConfig mf)
        {
            dpmmX = mf.PixPerMMX; //10 dots per mm
            dpmmY = mf.PixPerMMY;// 10;
            xres = mf.XRes;
            yres = mf.YRes;            
        }
        public void CreateDefault() 
        {
            layertime_ms = 5000;// 5 seconds default
            xres = 1024;
            yres = 768;
            ZThick = .025;
            plat_temp = 75;
            dpmmX = 102.4;
            dpmmY = 76.8;
            exportgcode = true;
            exportsvg = false;
            exportimages = false;
            SetDefaultCodes(); // set up default gcodes
        }

        /*This is used to serialize to the GCode post-header info*/
        public bool Load(String filename) 
        {
            try
            {
                XmlReader xr = (XmlReader)XmlReader.Create(filename);
                xr.ReadStartElement("SliceBuildConfig");
                dpmmX = double.Parse(xr.ReadElementString("DotsPermmX"));
                dpmmY = double.Parse(xr.ReadElementString("DotsPermmY"));
                xres = int.Parse(xr.ReadElementString("XResolution"));
                yres = int.Parse(xr.ReadElementString("YResolution"));
                ZThick = double.Parse(xr.ReadElementString("SliceHeight"));
                layertime_ms = int.Parse(xr.ReadElementString("LayerTime"));
                plat_temp = int.Parse(xr.ReadElementString("PlatformTemp"));
                m_headercode = xr.ReadElementString("HeaderGCode");
                m_perslicecode = xr.ReadElementString("PerSliceGCode");
                m_footercode = xr.ReadElementString("FooterGCode");
                xr.ReadEndElement();
                xr.Close();
                return true;
            }
            catch (Exception ex)
            {
                DebugLogger.Instance().LogRecord(ex.Message);
                return false;
            }       
        }
        public bool Save(String filename)
        {
            try 
            {
                XmlWriter xw =XmlWriter.Create(filename);
                xw.WriteStartElement("SliceBuildConfig");
                xw.WriteElementString("DotsPermmX", dpmmX.ToString());
                xw.WriteElementString("DotsPermmY", dpmmY.ToString());
                xw.WriteElementString("XResolution", xres.ToString());
                xw.WriteElementString("YResolution", yres.ToString());
                xw.WriteElementString("SliceHeight", ZThick.ToString());
                xw.WriteElementString("LayerTime", layertime_ms.ToString());
                xw.WriteElementString("PlatformTemp", plat_temp.ToString());
                xw.WriteElementString("HeaderGCode", m_headercode);
                xw.WriteElementString("PerSliceGCode", m_perslicecode);
                xw.WriteElementString("FooterGCode", m_footercode);
                xw.WriteEndElement();
                xw.Close();
                return true;
            }
            catch (Exception ex) 
            {
                DebugLogger.Instance().LogRecord(ex.Message);
                return false;
            }            
        }

        // these get stored to the gcode file as a reference
        public override String ToString() 
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("(****Build and Slicing Parameters****)\r\n");
            sb.Append("(dots per mm X   = " + dpmmX + " )\r\n");
            sb.Append("(dots per mm Y   = " + dpmmY + " )\r\n");
            sb.Append("(X resolution    = " + xres + " )\r\n");
            sb.Append("(Y resolution    = " + yres + " )\r\n");
            sb.Append("(Layer thickness = " + ZThick + " )\r\n");
            sb.Append("(Layer Time      = " + layertime_ms + ")\r\n");
            sb.Append("(Platform Temp   = " + plat_temp + ")\r\n");

            return sb.ToString();
        }
    }
}
