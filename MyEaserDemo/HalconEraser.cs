//
// File generated by HDevelop for HALCON/.NET (C#) Version 20.11.1.1
// Non-ASCII strings in this file are encoded in local-8-bit encoding (cp936).
// 
// Please note that non-ASCII characters in string constants are exported
// as octal codes in order to guarantee that the strings are correctly
// created on all systems, independent on any compiler settings.
// 
// Source files with different encoding should not be mixed in one project.
//

using System;
using System.Net.Mime;
using System.Windows.Forms;
using HalconDotNet;

public partial class HDevelopExport
{
#if (NO_EXPORT_MAIN || NO_EXPORT_APP_MAIN)
  public HDevelopExport()
  {
    // Default settings used in HDevelop
    HOperatorSet.SetSystem("width", 512);
    HOperatorSet.SetSystem("height", 512);
    if (HalconAPI.isWindows)
      HOperatorSet.SetSystem("use_window_thread","true");
    action();
  }
#endif

    // Procedures 
    // External procedures 
    // Chapter: Graphics / Text
    // Short Description: This procedure writes one or multiple text messages. 
    public void disp_message(HTuple hv_WindowHandle, HTuple hv_String, HTuple hv_CoordSystem,
        HTuple hv_Row, HTuple hv_Column, HTuple hv_Color, HTuple hv_Box)
    {



        // Local iconic variables 

        // Local control variables 

        HTuple hv_GenParamName = new HTuple(), hv_GenParamValue = new HTuple();
        HTuple hv_Color_COPY_INP_TMP = new HTuple(hv_Color);
        HTuple hv_Column_COPY_INP_TMP = new HTuple(hv_Column);
        HTuple hv_CoordSystem_COPY_INP_TMP = new HTuple(hv_CoordSystem);
        HTuple hv_Row_COPY_INP_TMP = new HTuple(hv_Row);

        // Initialize local and output iconic variables 
        try
        {
            //This procedure displays text in a graphics window.
            //
            //Input parameters:
            //WindowHandle: The WindowHandle of the graphics window, where
            //   the message should be displayed.
            //String: A tuple of strings containing the text messages to be displayed.
            //CoordSystem: If set to 'window', the text position is given
            //   with respect to the window coordinate system.
            //   If set to 'image', image coordinates are used.
            //   (This may be useful in zoomed images.)
            //Row: The row coordinate of the desired text position.
            //   You can pass a single value or a tuple of values.
            //   See the explanation below.
            //   Default: 12.
            //Column: The column coordinate of the desired text position.
            //   You can pass a single value or a tuple of values.
            //   See the explanation below.
            //   Default: 12.
            //Color: defines the color of the text as string.
            //   If set to [] or '' the currently set color is used.
            //   If a tuple of strings is passed, the colors are used cyclically
            //   for every text position defined by Row and Column,
            //   or every new text line in case of |Row| == |Column| == 1.
            //Box: A tuple controlling a possible box surrounding the text.
            //   Its entries:
            //   - Box[0]: Controls the box and its color. Possible values:
            //     -- 'true' (Default): An orange box is displayed.
            //     -- 'false': No box is displayed.
            //     -- color string: A box is displayed in the given color, e.g., 'white', '#FF00CC'.
            //   - Box[1] (Optional): Controls the shadow of the box. Possible values:
            //     -- 'true' (Default): A shadow is displayed in
            //               darker orange if Box[0] is not a color and in 'white' otherwise.
            //     -- 'false': No shadow is displayed.
            //     -- color string: A shadow is displayed in the given color, e.g., 'white', '#FF00CC'.
            //
            //It is possible to display multiple text strings in a single call.
            //In this case, some restrictions apply on the
            //parameters String, Row, and Column:
            //They can only have either 1 entry or n entries.
            //Behavior in the different cases:
            //   - Multiple text positions are specified, i.e.,
            //       - |Row| == n, |Column| == n
            //       - |Row| == n, |Column| == 1
            //       - |Row| == 1, |Column| == n
            //     In this case we distinguish:
            //       - |String| == n: Each element of String is displayed
            //                        at the corresponding position.
            //       - |String| == 1: String is displayed n times
            //                        at the corresponding positions.
            //   - Exactly one text position is specified,
            //      i.e., |Row| == |Column| == 1:
            //      Each element of String is display in a new textline.
            //
            //
            //Convert the parameters for disp_text.
            if ((int)((new HTuple(hv_Row_COPY_INP_TMP.TupleEqual(new HTuple()))).TupleOr(
                new HTuple(hv_Column_COPY_INP_TMP.TupleEqual(new HTuple())))) != 0)
            {

                hv_Color_COPY_INP_TMP.Dispose();
                hv_Column_COPY_INP_TMP.Dispose();
                hv_CoordSystem_COPY_INP_TMP.Dispose();
                hv_Row_COPY_INP_TMP.Dispose();
                hv_GenParamName.Dispose();
                hv_GenParamValue.Dispose();

                return;
            }
            if ((int)(new HTuple(hv_Row_COPY_INP_TMP.TupleEqual(-1))) != 0)
            {
                hv_Row_COPY_INP_TMP.Dispose();
                hv_Row_COPY_INP_TMP = 12;
            }
            if ((int)(new HTuple(hv_Column_COPY_INP_TMP.TupleEqual(-1))) != 0)
            {
                hv_Column_COPY_INP_TMP.Dispose();
                hv_Column_COPY_INP_TMP = 12;
            }
            //
            //Convert the parameter Box to generic parameters.
            hv_GenParamName.Dispose();
            hv_GenParamName = new HTuple();
            hv_GenParamValue.Dispose();
            hv_GenParamValue = new HTuple();
            if ((int)(new HTuple((new HTuple(hv_Box.TupleLength())).TupleGreater(0))) != 0)
            {
                if ((int)(new HTuple(((hv_Box.TupleSelect(0))).TupleEqual("false"))) != 0)
                {
                    //Display no box
                    using (HDevDisposeHelper dh = new HDevDisposeHelper())
                    {
                        {
                            HTuple
                              ExpTmpLocalVar_GenParamName = hv_GenParamName.TupleConcat(
                                "box");
                            hv_GenParamName.Dispose();
                            hv_GenParamName = ExpTmpLocalVar_GenParamName;
                        }
                    }
                    using (HDevDisposeHelper dh = new HDevDisposeHelper())
                    {
                        {
                            HTuple
                              ExpTmpLocalVar_GenParamValue = hv_GenParamValue.TupleConcat(
                                "false");
                            hv_GenParamValue.Dispose();
                            hv_GenParamValue = ExpTmpLocalVar_GenParamValue;
                        }
                    }
                }
                else if ((int)(new HTuple(((hv_Box.TupleSelect(0))).TupleNotEqual(
                    "true"))) != 0)
                {
                    //Set a color other than the default.
                    using (HDevDisposeHelper dh = new HDevDisposeHelper())
                    {
                        {
                            HTuple
                              ExpTmpLocalVar_GenParamName = hv_GenParamName.TupleConcat(
                                "box_color");
                            hv_GenParamName.Dispose();
                            hv_GenParamName = ExpTmpLocalVar_GenParamName;
                        }
                    }
                    using (HDevDisposeHelper dh = new HDevDisposeHelper())
                    {
                        {
                            HTuple
                              ExpTmpLocalVar_GenParamValue = hv_GenParamValue.TupleConcat(
                                hv_Box.TupleSelect(0));
                            hv_GenParamValue.Dispose();
                            hv_GenParamValue = ExpTmpLocalVar_GenParamValue;
                        }
                    }
                }
            }
            if ((int)(new HTuple((new HTuple(hv_Box.TupleLength())).TupleGreater(1))) != 0)
            {
                if ((int)(new HTuple(((hv_Box.TupleSelect(1))).TupleEqual("false"))) != 0)
                {
                    //Display no shadow.
                    using (HDevDisposeHelper dh = new HDevDisposeHelper())
                    {
                        {
                            HTuple
                              ExpTmpLocalVar_GenParamName = hv_GenParamName.TupleConcat(
                                "shadow");
                            hv_GenParamName.Dispose();
                            hv_GenParamName = ExpTmpLocalVar_GenParamName;
                        }
                    }
                    using (HDevDisposeHelper dh = new HDevDisposeHelper())
                    {
                        {
                            HTuple
                              ExpTmpLocalVar_GenParamValue = hv_GenParamValue.TupleConcat(
                                "false");
                            hv_GenParamValue.Dispose();
                            hv_GenParamValue = ExpTmpLocalVar_GenParamValue;
                        }
                    }
                }
                else if ((int)(new HTuple(((hv_Box.TupleSelect(1))).TupleNotEqual(
                    "true"))) != 0)
                {
                    //Set a shadow color other than the default.
                    using (HDevDisposeHelper dh = new HDevDisposeHelper())
                    {
                        {
                            HTuple
                              ExpTmpLocalVar_GenParamName = hv_GenParamName.TupleConcat(
                                "shadow_color");
                            hv_GenParamName.Dispose();
                            hv_GenParamName = ExpTmpLocalVar_GenParamName;
                        }
                    }
                    using (HDevDisposeHelper dh = new HDevDisposeHelper())
                    {
                        {
                            HTuple
                              ExpTmpLocalVar_GenParamValue = hv_GenParamValue.TupleConcat(
                                hv_Box.TupleSelect(1));
                            hv_GenParamValue.Dispose();
                            hv_GenParamValue = ExpTmpLocalVar_GenParamValue;
                        }
                    }
                }
            }
            //Restore default CoordSystem behavior.
            if ((int)(new HTuple(hv_CoordSystem_COPY_INP_TMP.TupleNotEqual("window"))) != 0)
            {
                hv_CoordSystem_COPY_INP_TMP.Dispose();
                hv_CoordSystem_COPY_INP_TMP = "image";
            }
            //
            if ((int)(new HTuple(hv_Color_COPY_INP_TMP.TupleEqual(""))) != 0)
            {
                //disp_text does not accept an empty string for Color.
                hv_Color_COPY_INP_TMP.Dispose();
                hv_Color_COPY_INP_TMP = new HTuple();
            }
            //
            HOperatorSet.DispText(hv_WindowHandle, hv_String, hv_CoordSystem_COPY_INP_TMP,
                hv_Row_COPY_INP_TMP, hv_Column_COPY_INP_TMP, hv_Color_COPY_INP_TMP, hv_GenParamName,
                hv_GenParamValue);

            hv_Color_COPY_INP_TMP.Dispose();
            hv_Column_COPY_INP_TMP.Dispose();
            hv_CoordSystem_COPY_INP_TMP.Dispose();
            hv_Row_COPY_INP_TMP.Dispose();
            hv_GenParamName.Dispose();
            hv_GenParamValue.Dispose();

            return;
        }
        catch (HalconException HDevExpDefaultException)
        {

            hv_Color_COPY_INP_TMP.Dispose();
            hv_Column_COPY_INP_TMP.Dispose();
            hv_CoordSystem_COPY_INP_TMP.Dispose();
            hv_Row_COPY_INP_TMP.Dispose();
            hv_GenParamName.Dispose();
            hv_GenParamValue.Dispose();

            throw HDevExpDefaultException;
        }
    }

    // Chapter: Graphics / Text
    // Short Description: Set font independent of OS 
    public void set_display_font(HTuple hv_WindowHandle, HTuple hv_Size, HTuple hv_Font,
        HTuple hv_Bold, HTuple hv_Slant)
    {



        // Local iconic variables 

        // Local control variables 

        HTuple hv_OS = new HTuple(), hv_Fonts = new HTuple();
        HTuple hv_Style = new HTuple(), hv_Exception = new HTuple();
        HTuple hv_AvailableFonts = new HTuple(), hv_Fdx = new HTuple();
        HTuple hv_Indices = new HTuple();
        HTuple hv_Font_COPY_INP_TMP = new HTuple(hv_Font);
        HTuple hv_Size_COPY_INP_TMP = new HTuple(hv_Size);

        // Initialize local and output iconic variables 
        try
        {
            //This procedure sets the text font of the current window with
            //the specified attributes.
            //
            //Input parameters:
            //WindowHandle: The graphics window for which the font will be set
            //Size: The font size. If Size=-1, the default of 16 is used.
            //Bold: If set to 'true', a bold font is used
            //Slant: If set to 'true', a slanted font is used
            //
            hv_OS.Dispose();
            HOperatorSet.GetSystem("operating_system", out hv_OS);
            if ((int)((new HTuple(hv_Size_COPY_INP_TMP.TupleEqual(new HTuple()))).TupleOr(
                new HTuple(hv_Size_COPY_INP_TMP.TupleEqual(-1)))) != 0)
            {
                hv_Size_COPY_INP_TMP.Dispose();
                hv_Size_COPY_INP_TMP = 16;
            }
            if ((int)(new HTuple(((hv_OS.TupleSubstr(0, 2))).TupleEqual("Win"))) != 0)
            {
                //Restore previous behaviour
                using (HDevDisposeHelper dh = new HDevDisposeHelper())
                {
                    {
                        HTuple
                          ExpTmpLocalVar_Size = ((1.13677 * hv_Size_COPY_INP_TMP)).TupleInt()
                            ;
                        hv_Size_COPY_INP_TMP.Dispose();
                        hv_Size_COPY_INP_TMP = ExpTmpLocalVar_Size;
                    }
                }
            }
            else
            {
                using (HDevDisposeHelper dh = new HDevDisposeHelper())
                {
                    {
                        HTuple
                          ExpTmpLocalVar_Size = hv_Size_COPY_INP_TMP.TupleInt()
                            ;
                        hv_Size_COPY_INP_TMP.Dispose();
                        hv_Size_COPY_INP_TMP = ExpTmpLocalVar_Size;
                    }
                }
            }
            if ((int)(new HTuple(hv_Font_COPY_INP_TMP.TupleEqual("Courier"))) != 0)
            {
                hv_Fonts.Dispose();
                hv_Fonts = new HTuple();
                hv_Fonts[0] = "Courier";
                hv_Fonts[1] = "Courier 10 Pitch";
                hv_Fonts[2] = "Courier New";
                hv_Fonts[3] = "CourierNew";
                hv_Fonts[4] = "Liberation Mono";
            }
            else if ((int)(new HTuple(hv_Font_COPY_INP_TMP.TupleEqual("mono"))) != 0)
            {
                hv_Fonts.Dispose();
                hv_Fonts = new HTuple();
                hv_Fonts[0] = "Consolas";
                hv_Fonts[1] = "Menlo";
                hv_Fonts[2] = "Courier";
                hv_Fonts[3] = "Courier 10 Pitch";
                hv_Fonts[4] = "FreeMono";
                hv_Fonts[5] = "Liberation Mono";
            }
            else if ((int)(new HTuple(hv_Font_COPY_INP_TMP.TupleEqual("sans"))) != 0)
            {
                hv_Fonts.Dispose();
                hv_Fonts = new HTuple();
                hv_Fonts[0] = "Luxi Sans";
                hv_Fonts[1] = "DejaVu Sans";
                hv_Fonts[2] = "FreeSans";
                hv_Fonts[3] = "Arial";
                hv_Fonts[4] = "Liberation Sans";
            }
            else if ((int)(new HTuple(hv_Font_COPY_INP_TMP.TupleEqual("serif"))) != 0)
            {
                hv_Fonts.Dispose();
                hv_Fonts = new HTuple();
                hv_Fonts[0] = "Times New Roman";
                hv_Fonts[1] = "Luxi Serif";
                hv_Fonts[2] = "DejaVu Serif";
                hv_Fonts[3] = "FreeSerif";
                hv_Fonts[4] = "Utopia";
                hv_Fonts[5] = "Liberation Serif";
            }
            else
            {
                hv_Fonts.Dispose();
                hv_Fonts = new HTuple(hv_Font_COPY_INP_TMP);
            }
            hv_Style.Dispose();
            hv_Style = "";
            if ((int)(new HTuple(hv_Bold.TupleEqual("true"))) != 0)
            {
                using (HDevDisposeHelper dh = new HDevDisposeHelper())
                {
                    {
                        HTuple
                          ExpTmpLocalVar_Style = hv_Style + "Bold";
                        hv_Style.Dispose();
                        hv_Style = ExpTmpLocalVar_Style;
                    }
                }
            }
            else if ((int)(new HTuple(hv_Bold.TupleNotEqual("false"))) != 0)
            {
                hv_Exception.Dispose();
                hv_Exception = "Wrong value of control parameter Bold";
                throw new HalconException(hv_Exception);
            }
            if ((int)(new HTuple(hv_Slant.TupleEqual("true"))) != 0)
            {
                using (HDevDisposeHelper dh = new HDevDisposeHelper())
                {
                    {
                        HTuple
                          ExpTmpLocalVar_Style = hv_Style + "Italic";
                        hv_Style.Dispose();
                        hv_Style = ExpTmpLocalVar_Style;
                    }
                }
            }
            else if ((int)(new HTuple(hv_Slant.TupleNotEqual("false"))) != 0)
            {
                hv_Exception.Dispose();
                hv_Exception = "Wrong value of control parameter Slant";
                throw new HalconException(hv_Exception);
            }
            if ((int)(new HTuple(hv_Style.TupleEqual(""))) != 0)
            {
                hv_Style.Dispose();
                hv_Style = "Normal";
            }
            hv_AvailableFonts.Dispose();
            HOperatorSet.QueryFont(hv_WindowHandle, out hv_AvailableFonts);
            hv_Font_COPY_INP_TMP.Dispose();
            hv_Font_COPY_INP_TMP = "";
            for (hv_Fdx = 0; (int)hv_Fdx <= (int)((new HTuple(hv_Fonts.TupleLength())) - 1); hv_Fdx = (int)hv_Fdx + 1)
            {
                hv_Indices.Dispose();
                using (HDevDisposeHelper dh = new HDevDisposeHelper())
                {
                    hv_Indices = hv_AvailableFonts.TupleFind(
                        hv_Fonts.TupleSelect(hv_Fdx));
                }
                if ((int)(new HTuple((new HTuple(hv_Indices.TupleLength())).TupleGreater(
                    0))) != 0)
                {
                    if ((int)(new HTuple(((hv_Indices.TupleSelect(0))).TupleGreaterEqual(0))) != 0)
                    {
                        hv_Font_COPY_INP_TMP.Dispose();
                        using (HDevDisposeHelper dh = new HDevDisposeHelper())
                        {
                            hv_Font_COPY_INP_TMP = hv_Fonts.TupleSelect(
                                hv_Fdx);
                        }
                        break;
                    }
                }
            }
            if ((int)(new HTuple(hv_Font_COPY_INP_TMP.TupleEqual(""))) != 0)
            {
                throw new HalconException("Wrong value of control parameter Font");
            }
            using (HDevDisposeHelper dh = new HDevDisposeHelper())
            {
                {
                    HTuple
                      ExpTmpLocalVar_Font = (((hv_Font_COPY_INP_TMP + "-") + hv_Style) + "-") + hv_Size_COPY_INP_TMP;
                    hv_Font_COPY_INP_TMP.Dispose();
                    hv_Font_COPY_INP_TMP = ExpTmpLocalVar_Font;
                }
            }
            HOperatorSet.SetFont(hv_WindowHandle, hv_Font_COPY_INP_TMP);

            hv_Font_COPY_INP_TMP.Dispose();
            hv_Size_COPY_INP_TMP.Dispose();
            hv_OS.Dispose();
            hv_Fonts.Dispose();
            hv_Style.Dispose();
            hv_Exception.Dispose();
            hv_AvailableFonts.Dispose();
            hv_Fdx.Dispose();
            hv_Indices.Dispose();

            return;
        }
        catch (HalconException HDevExpDefaultException)
        {

            hv_Font_COPY_INP_TMP.Dispose();
            hv_Size_COPY_INP_TMP.Dispose();
            hv_OS.Dispose();
            hv_Fonts.Dispose();
            hv_Style.Dispose();
            hv_Exception.Dispose();
            hv_AvailableFonts.Dispose();
            hv_Fdx.Dispose();
            hv_Indices.Dispose();

            throw HDevExpDefaultException;
        }
    }

    // Local procedures 
    public void Eraser(HObject ho_Image, HTuple hv_WindowHandle)
    {
        // Stack for temporary objects 
        HObject[] OTemp = new HObject[20];

        // Local iconic variables 

        HObject ho_Rectangle, ho_ImageReduced, ho_region_removeds;
        HObject ho_Eraser = null, ho_RegionDifference, ho_ModelContours;
        HObject ho_ContoursAffinTrans;

        // Local control variables 

        HTuple hv_Row1 = new HTuple(), hv_Column1 = new HTuple();
        HTuple hv_Row2 = new HTuple(), hv_Column2 = new HTuple();
        HTuple hv_EraserSize = new HTuple(), hv_EraserType = new HTuple();
        HTuple hv_Rows = new HTuple(), hv_Cols = new HTuple();
        HTuple hv_Button = new HTuple(), hv_Row = new HTuple();
        HTuple hv_Column = new HTuple(), hv_ModelID = new HTuple();
        HTuple hv_Angle = new HTuple(), hv_Score = new HTuple();
        HTuple hv_HomMat2D = new HTuple();
        // Initialize local and output iconic variables 
        HOperatorSet.GenEmptyObj(out ho_Rectangle);
        HOperatorSet.GenEmptyObj(out ho_ImageReduced);
        HOperatorSet.GenEmptyObj(out ho_region_removeds);
        HOperatorSet.GenEmptyObj(out ho_Eraser);
        HOperatorSet.GenEmptyObj(out ho_RegionDifference);
        HOperatorSet.GenEmptyObj(out ho_ModelContours);
        HOperatorSet.GenEmptyObj(out ho_ContoursAffinTrans);
        try
        {
            //选择区域
            hv_Row1.Dispose(); hv_Column1.Dispose(); hv_Row2.Dispose(); hv_Column2.Dispose();
            HOperatorSet.DrawRectangle1(hv_WindowHandle, out hv_Row1, out hv_Column1, out hv_Row2,
                out hv_Column2);
            ho_Rectangle.Dispose();
            HOperatorSet.GenRectangle1(out ho_Rectangle, hv_Row1, hv_Column1, hv_Row2,
                hv_Column2);
            ho_ImageReduced.Dispose();
            HOperatorSet.ReduceDomain(ho_Image, ho_Rectangle, out ho_ImageReduced);

            HOperatorSet.DispObj(ho_ImageReduced, hv_WindowHandle);
            //*橡皮擦功能,特征屏蔽***********************************
            //橡皮擦大小
            hv_EraserSize.Dispose();
            hv_EraserSize = 40;
            //橡皮擦形状
            hv_EraserType.Dispose();
            hv_EraserType = "rectangle2";
            ho_region_removeds.Dispose();
            HOperatorSet.GenEmptyObj(out ho_region_removeds);
            //橡皮擦路过的坐标集
            hv_Rows.Dispose();
            hv_Rows = new HTuple();
            hv_Cols.Dispose();
            hv_Cols = new HTuple();
            //擦除工作
            hv_Button.Dispose();
            hv_Button = 0;
            //set_display_font(hv_WindowHandle, 26, "mono", "true", "false");
            //disp_message(hv_WindowHandle, "按下鼠标进行擦除功能，松开鼠标将结束", "window",
            //    12, 12, "red", "false");
            while (hv_Button == 0)
            {
                hv_Row.Dispose(); hv_Column.Dispose(); hv_Button.Dispose();
                HOperatorSet.GetMbutton(hv_WindowHandle, out hv_Row, out hv_Column, out hv_Button);
                while (hv_Button == 1)
                {
                    Application.DoEvents();
                    hv_Row.Dispose(); hv_Column.Dispose(); hv_Button.Dispose();
                    HOperatorSet.GetMposition(hv_WindowHandle, out hv_Row, out hv_Column, out hv_Button);

                    //生成橡皮擦擦过的区域
                    if ((int)(new HTuple(hv_EraserType.TupleEqual("rectangle"))) != 0)
                    {
                        ho_Eraser.Dispose();
                        HOperatorSet.GenRectangle2(out ho_Eraser, hv_Row, hv_Column, 0, hv_EraserSize,
                            hv_EraserSize);
                    }
                    else
                    {
                        ho_Eraser.Dispose();
                        HOperatorSet.GenCircle(out ho_Eraser, hv_Row, hv_Column, hv_EraserSize);
                    }
                    //橡皮擦区域合并
                    {
                        HOperatorSet.Union2(ho_region_removeds, ho_Eraser, out ho_region_removeds);
                        //ho_region_removeds.Dispose();
                        //ho_region_removeds = ExpTmpOutVar_0;
                    }
                    HOperatorSet.SetColor(hv_WindowHandle, "red");
                    HOperatorSet.DispObj(ho_region_removeds, hv_WindowHandle);

                }
            }
            //区域相减
            ho_RegionDifference.Dispose();
            HOperatorSet.Difference(ho_ImageReduced, ho_region_removeds, out ho_RegionDifference
                );

            //HObject ho_ImageReduced1;
            //HOperatorSet.GenEmptyObj(out ho_ImageReduced1);
            //ho_ImageReduced1.Dispose();
            HOperatorSet.ReduceDomain(ho_ImageReduced, ho_RegionDifference, out HObject ho_ImageReduced1);
            ho_ImageReduced.Dispose();
            HOperatorSet.ClearWindow(hv_WindowHandle);
            HOperatorSet.DispObj(ho_region_removeds, hv_WindowHandle);
            HOperatorSet.DispObj(ho_ImageReduced1, hv_WindowHandle);


            //*创建模板******************************************************
            hv_ModelID.Dispose();
            HOperatorSet.CreateShapeModel(ho_ImageReduced, "auto", -0.39, 0.79, "auto",
                "auto", "use_polarity", "auto", "auto", out hv_ModelID);
            using (HDevDisposeHelper dh = new HDevDisposeHelper())
            {
                hv_Row.Dispose(); hv_Column.Dispose(); hv_Angle.Dispose(); hv_Score.Dispose();
                HOperatorSet.FindShapeModel(ho_Image, hv_ModelID, (new HTuple(-180)).TupleRad()
                    , (new HTuple(180)).TupleRad(), 0.5, 1, 0.5, "least_squares", 0, 0.9, out hv_Row,
                    out hv_Column, out hv_Angle, out hv_Score);
            }
            //获取模板轮廓
            ho_ModelContours.Dispose();
            HOperatorSet.GetShapeModelContours(out ho_ModelContours, hv_ModelID, 1);
            if (HDevWindowStack.IsOpen())
            {
                HOperatorSet.ClearWindow(HDevWindowStack.GetActive());
            }
            if (HDevWindowStack.IsOpen())
            {
                HOperatorSet.DispObj(ho_Image, HDevWindowStack.GetActive());
            }
            if (HDevWindowStack.IsOpen())
            {
                HOperatorSet.SetLineWidth(HDevWindowStack.GetActive(), 2);
            }
            //将模板映射到目标上
            hv_HomMat2D.Dispose();
            HOperatorSet.VectorAngleToRigid(0, 0, 0, hv_Row, hv_Column, hv_Angle, out hv_HomMat2D);
            ho_ContoursAffinTrans.Dispose();
            HOperatorSet.AffineTransContourXld(ho_ModelContours, out ho_ContoursAffinTrans,
                hv_HomMat2D);
            ho_Rectangle.Dispose();
            ho_ImageReduced.Dispose();
            ho_region_removeds.Dispose();
            ho_Eraser.Dispose();
            ho_RegionDifference.Dispose();
            ho_ModelContours.Dispose();
            ho_ContoursAffinTrans.Dispose();

            hv_Row1.Dispose();
            hv_Column1.Dispose();
            hv_Row2.Dispose();
            hv_Column2.Dispose();
            hv_EraserSize.Dispose();
            hv_EraserType.Dispose();
            hv_Rows.Dispose();
            hv_Cols.Dispose();
            hv_Button.Dispose();
            hv_Row.Dispose();
            hv_Column.Dispose();
            hv_ModelID.Dispose();
            hv_Angle.Dispose();
            hv_Score.Dispose();
            hv_HomMat2D.Dispose();

            return;
        }
        catch (HalconException HDevExpDefaultException)
        {
            ho_Rectangle.Dispose();
            ho_ImageReduced.Dispose();
            ho_region_removeds.Dispose();
            ho_Eraser.Dispose();
            ho_RegionDifference.Dispose();
            ho_ModelContours.Dispose();
            ho_ContoursAffinTrans.Dispose();

            hv_Row1.Dispose();
            hv_Column1.Dispose();
            hv_Row2.Dispose();
            hv_Column2.Dispose();
            hv_EraserSize.Dispose();
            hv_EraserType.Dispose();
            hv_Rows.Dispose();
            hv_Cols.Dispose();
            hv_Button.Dispose();
            hv_Row.Dispose();
            hv_Column.Dispose();
            hv_ModelID.Dispose();
            hv_Angle.Dispose();
            hv_Score.Dispose();
            hv_HomMat2D.Dispose();
            MessageBox.Show(HDevExpDefaultException.ToString());
            //throw HDevExpDefaultException;
        }
    }

#if NO_EXPORT_MAIN
    // Main procedure 
    private void action()
  {


    // Local iconic variables 

    HObject ho_Image;

    // Local control variables 

    HTuple hv_WindowHandle = new HTuple();
    // Initialize local and output iconic variables 
    HOperatorSet.GenEmptyObj(out ho_Image);
    try
    {
      if (HDevWindowStack.IsOpen())
      {
        //dev_clear_window ()
      }
      if (HDevWindowStack.IsOpen())
      {
        //dev_close_window ()
      }
      //dev_open_window (0, 0, 512, 512, 'black', WindowHandle)
      //read_image (Image, 'printer_chip/printer_chip_01')

      //选择区域
      //* draw_rectangle1 (WindowHandle, Row1, Column1, Row2, Column2)
      //* gen_rectangle1 (Rectangle, Row1, Column1, Row2, Column2)
      //* reduce_domain (Image, Rectangle, ImageReduced)
      if (HDevWindowStack.IsOpen())
      {
        //dev_clear_window ()
      }
      if (HDevWindowStack.IsOpen())
      {
        //dev_display (ImageReduced)
      }
      //*橡皮擦功能,特征屏蔽***********************************
      //橡皮擦大小
      //EraserSize := 40
      //橡皮擦形状
      //EraserType := 'rectangle2'
      //gen_empty_obj (region_removeds)
      //橡皮擦路过的坐标集
      //Rows := []
      //Cols := []
      //擦除工作
      //Button := 0
      //* set_display_font (WindowHandle, 26, 'mono', 'true', 'false')
      //* disp_message (WindowHandle, '按下鼠标进行擦除功能，松开鼠标将结束', 'window', 12, 12, 'red', 'false')
      //while (Button == 0)
        //*     get_mbutton (WindowHandle, Row, Column, Button)
        //while (Button == 1)
          //*     get_mposition (WindowHandle, Row, Column, Button)
          //Rows := [Rows,Row]
          //Cols := [Cols,Column]
          //生成橡皮擦擦过的区域
          //*     if(EraserType=='rectangle')   
          //*      gen_rectangle2 (Eraser,Row, Column,0, EraserSize,EraserSize)
          //*     else
          //*      gen_circle (Eraser, Row, Column, EraserSize)
          //*     endif
          //橡皮擦区域合并
          //*     union2(region_removeds,Eraser,region_removeds)
        //endwhile
      //endwhile
      //区域相减
      //* difference (ImageReduced, region_removeds, RegionDifference)
      //* reduce_domain (ImageReduced, RegionDifference, ImageReduced)
      //*创建模板******************************************************
      //* create_shape_model (ImageReduced, 'auto', -0.39, 0.79, 'auto', 'auto', 'use_polarity', 'auto', 'auto', ModelID)
      //* find_shape_model (Image, ModelID, rad(-180), rad(180), 0.5, 1, 0.5, 'least_squares', 0, 0.9, Row, Column, Angle, Score)
      //获取模板轮廓
      //* get_shape_model_contours (ModelContours, ModelID, 1)
      if (HDevWindowStack.IsOpen())
      {
        //dev_clear_window ()
      }
      //* dev_display (Image)
      if (HDevWindowStack.IsOpen())
      {
        //dev_set_line_width (2)
      }
      //将模板映射到目标上
      //* vector_angle_to_rigid (0, 0, 0, Row, Column, Angle, HomMat2D)
      //* affine_trans_contour_xld (ModelContours, ContoursAffinTrans, HomMat2D)
      //return ()
      ho_Image.Dispose();
      HOperatorSet.ReadImage(out ho_Image, "printer_chip/printer_chip_01");
      if (HDevWindowStack.IsOpen())
      {
        hv_WindowHandle = HDevWindowStack.GetActive();
      }
      Eraser(ho_Image, hv_WindowHandle);

    }
    catch (HalconException HDevExpDefaultException)
    {
      ho_Image.Dispose();

      hv_WindowHandle.Dispose();

      throw HDevExpDefaultException;
    }
    ho_Image.Dispose();

    hv_WindowHandle.Dispose();

  }

#endif


}
#if (NO_EXPORT_MAIN || NO_EXPORT_APP_MAIN)
public class HDevelopExportApp
{
  static void Main(string[] args)
  {
    new HDevelopExport();
  }
}
#endif

