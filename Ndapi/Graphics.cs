﻿using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;
using System.Collections.Generic;

namespace Ndapi
{
    /// <summary>
    /// Represents a graphics opbject.
    /// </summary>
    public class Graphics : NdapiObject
    {
        /// <summary>
        /// Creates a graphics object.
        /// </summary>
        /// <param name="canvas">Graphics owner.</param>
        /// <param name="name">Graphics name.</param>
        public Graphics(Canvas canvas, string name) : base(name, ObjectType.Graphics, canvas)
        {
        }

        /// <summary>
        /// Creates a graphics object.
        /// </summary>
        /// <param name="graphics">Graphics owner.</param>
        /// <param name="name">Graphics name.</param>
        public Graphics(Graphics graphics, string name) : base(name, ObjectType.Graphics, graphics)
        {
        }

        /// <summary>
        /// Creates a graphics object.
        /// </summary>
        /// <param name="group">Graphics owner.</param>
        /// <param name="name">Graphics name.</param>
        public Graphics(ObjectGroup group, string name) : base(name, ObjectType.Graphics, group)
        {
        }

        /// <summary>
        /// Creates a graphics object.
        /// </summary>
        /// <param name="library">Graphics owner.</param>
        /// <param name="name">Graphics name.</param>
        public Graphics(ObjectLibrary library, string name) : base(name, ObjectType.Graphics, library)
        {
        }

        /// <summary>
        /// Creates a graphics object.
        /// </summary>
        /// <param name="tab">Graphics owner.</param>
        /// <param name="name">Graphics name.</param>
        public Graphics(TabPage tab, string name) : base(name, ObjectType.Graphics, tab)
        {
        }

        internal Graphics(ObjectSafeHandle handle) : base(handle)
        {
        }

        /// <summary>
        /// Gets or sets whether runtime can automatically expand a frame when the contents of the
        /// frame extend beyond the frame's borders.
        /// </summary>
        public bool AllowExpansion
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_ALLOW_EXPANSION); }
            set { SetBooleanProperty(NdapiConstants.D2FP_ALLOW_EXPANSION, value); }
        }

        /// <summary>
        /// Gets or sets whether runtime can conserve space within a frame by splitting a prompt into multiple lines.
        /// </summary>
        public bool AllowMultilinePrompts
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_ALLOW_MLT_LIN_PRMPTS); }
            set { SetBooleanProperty(NdapiConstants.D2FP_ALLOW_MLT_LIN_PRMPTS, value); }
        }

        /// <summary>
        /// Gets or sets whether runtime will attach prompts to the item's start edge if there is enough space.
        /// </summary>
        public bool AllowStartAttachedPrompts
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_ALLOW_STRT_ATT_PRMPTS); }
            set { SetBooleanProperty(NdapiConstants.D2FP_ALLOW_STRT_ATT_PRMPTS, value); }
        }

        /// <summary>
        /// Gets or sets whether runtime will attach prompts to the item's top edge if there is enough space.
        /// </summary>
        public bool AllowTopAttachedPrompts
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_ALLOW_TOP_ATT_PRMPTS); }
            set { SetBooleanProperty(NdapiConstants.D2FP_ALLOW_TOP_ATT_PRMPTS, value); }
        }

        /// <summary>
        /// Gets or sets the line arrow style.
        /// </summary>
        public LineArrowStyle LineArrowStyle
        {
            get { return GetNumberProperty<LineArrowStyle>(NdapiConstants.D2FP_ARROW_STY); }
            set { SetNumberProperty(NdapiConstants.D2FP_ARROW_STY, value); }
        }

        /// <summary>
        /// Gets or sets the background color.
        /// </summary>
        public string BackgroundColor
        {
            get { return GetStringProperty(NdapiConstants.D2FP_BACK_COLOR); }
            set { SetStringProperty(NdapiConstants.D2FP_BACK_COLOR, value); }
        }

        /// <summary>
        /// Gets or sets the appearance of the object border.
        /// </summary>
        public Bevel Bevel
        {
            get { return GetNumberProperty<Bevel>(NdapiConstants.D2FP_BEVEL); }
            set { SetNumberProperty(NdapiConstants.D2FP_BEVEL, value); }
        }


        /// <summary>
        /// Gets or sets the object edge cap style.
        /// </summary>
        public ObjectEdgeCapStyle ObjectEdgeCapStyle
        {
            get { return GetNumberProperty<ObjectEdgeCapStyle>(NdapiConstants.D2FP_CAP_STY); }
            set { SetNumberProperty(NdapiConstants.D2FP_CAP_STY, value); }
        }

        /// <summary>
        /// Gets or sets the clipping height.
        /// </summary>
        public int ClippingHeight
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_CLIP_HGT); }
            set { SetNumberProperty(NdapiConstants.D2FP_CLIP_HGT, value); }
        }

        /// <summary>
        /// Gets or sets the clipping width.
        /// </summary>
        public int ClippingWidth
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_CLIP_WID); }
            set { SetNumberProperty(NdapiConstants.D2FP_CLIP_WID, value); }
        }

        /// <summary>
        /// Gets or sets the clipping X origin.
        /// </summary>
        public int ClippingXOrigin
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_CLIP_X_POS); }
            set { SetNumberProperty(NdapiConstants.D2FP_CLIP_X_POS, value); }
        }

        /// <summary>
        /// Gets or sets the clipping Y origin.
        /// </summary>
        public int ClippingYOrigin
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_CLIP_Y_POS); }
            set { SetNumberProperty(NdapiConstants.D2FP_CLIP_Y_POS, value); }
        }

        /// <summary>
        /// Gets or sets whether an arc is closed.
        /// </summary>
        public bool Closed
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_CLOSED); }
            set { SetBooleanProperty(NdapiConstants.D2FP_CLOSED, value); }
        }

        /// <summary>
        /// Gets or sets the X corner radius.
        /// </summary>
        public int XCornerRadius
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_CORNER_RADIUS_X); }
            set { SetNumberProperty(NdapiConstants.D2FP_CORNER_RADIUS_X, value); }
        }

        /// <summary>
        /// Gets or sets the Y corner radius.
        /// </summary>
        public int YCornerRadius
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_CORNER_RADIUS_Y); }
            set { SetNumberProperty(NdapiConstants.D2FP_CORNER_RADIUS_Y, value); }
        }

        /// <summary>
        /// Gets or sets the custom spacing.
        /// </summary>
        public int CustomSpacing
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_CSTM_SPCING); }
            set { SetNumberProperty(NdapiConstants.D2FP_CSTM_SPCING, value); }
        }

        /// <summary>
        /// Gets or sets the dash style.
        /// </summary>
        public DashStyle DashStyle
        {
            get { return GetNumberProperty<DashStyle>(NdapiConstants.D2FP_DASH_STY); }
            set { SetNumberProperty(NdapiConstants.D2FP_DASH_STY, value); }
        }

        /// <summary>
        /// Gets or sets the display quality.
        /// </summary>
        public DisplayQuality DisplayQuality
        {
            get { return GetNumberProperty<DisplayQuality>(NdapiConstants.D2FP_DISP_QLTY); }
            set { SetNumberProperty(NdapiConstants.D2FP_DISP_QLTY, value); }
        }

        /// <summary>
        /// Gets or sets the distance between records.
        /// </summary>
        public int DistanceBetweenRecords
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_DIST_BTWN_RECS); }
            set { SetNumberProperty(NdapiConstants.D2FP_DIST_BTWN_RECS, value); }
        }

        /// <summary>
        /// Gets or sets whether graphics dithers image.
        /// </summary>
        public bool GraphicsDithersImage
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_DITHER); }
            set { SetBooleanProperty(NdapiConstants.D2FP_DITHER, value); }
        }

        /// <summary>
        /// Gets or sets the edge background color.
        /// </summary>
        public string EdgeBackgroundColor
        {
            get { return GetStringProperty(NdapiConstants.D2FP_EDGE_BACK_COLOR); }
            set { SetStringProperty(NdapiConstants.D2FP_EDGE_BACK_COLOR, value); }
        }

        /// <summary>
        /// Gets or sets the edge foreground color.
        /// </summary>
        public string EdgeForegroundColor
        {
            get { return GetStringProperty(NdapiConstants.D2FP_EDGE_FORE_COLOR); }
            set { SetStringProperty(NdapiConstants.D2FP_EDGE_FORE_COLOR, value); }
        }

        /// <summary>
        /// Gets or sets the pattern to be used for the fill region.
        /// Patterns are rendered in the two colors specified by <see cref="BackgroundColor"/> and <see cref="ForegroundColor"/>.
        /// </summary>
        public string FillPattern
        {
            get { return GetStringProperty(NdapiConstants.D2FP_FILL_PAT); }
            set { SetStringProperty(NdapiConstants.D2FP_FILL_PAT, value); }
        }

        /// <summary>
        /// Gets or sets whether runtime should use a fixed size for bounding box.
        /// </summary>
        public bool FixedSizeForBoundingBox
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_FIXED_BOUNDING_BX); }
            set { SetBooleanProperty(NdapiConstants.D2FP_FIXED_BOUNDING_BX, value); }
        }

        /// <summary>
        /// Gets or sets whether point size scales with object.
        /// </summary>
        public bool PointSizeScalable
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_FONT_SCALEABLE); }
            set { SetBooleanProperty(NdapiConstants.D2FP_FONT_SCALEABLE, value); }
        }

        /// <summary>
        /// Gets or sets the foreground color.
        /// </summary>
        public string ForegroundColor
        {
            get { return GetStringProperty(NdapiConstants.D2FP_FORE_COLOR); }
            set { SetStringProperty(NdapiConstants.D2FP_FORE_COLOR, value); }
        }

        /// <summary>
        /// Gets or sets the frame alignment.
        /// </summary>
        public FrameAlignment FrameAlignment
        {
            get { return GetNumberProperty<FrameAlignment>(NdapiConstants.D2FP_FRAME_ALIGN); }
            set { SetNumberProperty(NdapiConstants.D2FP_FRAME_ALIGN, value); }
        }

        /// <summary>
        /// Gets or sets the frame title.
        /// </summary>
        public string FrameTitle
        {
            get { return GetStringProperty(NdapiConstants.D2FP_FRAME_TTL); }
            set { SetStringProperty(NdapiConstants.D2FP_FRAME_TTL, value); }
        }

        /// <summary>
        /// Gets or sets the frame title alignment.
        /// </summary>
        public FrameTitleAlignment FrameTitleAlignment
        {
            get { return GetNumberProperty<FrameTitleAlignment>(NdapiConstants.D2FP_FRAME_TTL_ALIGN); }
            set { SetNumberProperty(NdapiConstants.D2FP_FRAME_TTL_ALIGN, value); }
        }

        /// <summary>
        /// Gets or sets the frame title background color.
        /// </summary>
        public string FrameTitleBackgroundColor
        {
            get { return GetStringProperty(NdapiConstants.D2FP_FRAME_TTL_BACK_COLOR); }
            set { SetStringProperty(NdapiConstants.D2FP_FRAME_TTL_BACK_COLOR, value); }
        }

        /// <summary>
        /// Gets or sets the pattern to be used for the frame's title fill region.
        /// Patterns are rendered in the two colors specified by <see cref="FrameTitleBackgroundColor"/> and <see cref="FrameTitleForegroundColor"/>.
        /// </summary>
        public string FrameTitleFillPattern
        {
            get { return GetStringProperty(NdapiConstants.D2FP_FRAME_TTL_FILL_PAT); }
            set { SetStringProperty(NdapiConstants.D2FP_FRAME_TTL_FILL_PAT, value); }
        }

        /// <summary>
        /// Gets or sets the frame's font name.
        /// </summary>
        public string FrameTitleFontName
        {
            get { return GetStringProperty(NdapiConstants.D2FP_FRAME_TTL_FONT_NAM); }
            set { SetStringProperty(NdapiConstants.D2FP_FRAME_TTL_FONT_NAM, value); }
        }

        /// <summary>
        /// Gets or sets the frame's font size.
        /// </summary>
        public int FrameTitleFontSize
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_FRAME_TTL_FONT_SIZ); }
            set { SetNumberProperty(NdapiConstants.D2FP_FRAME_TTL_FONT_SIZ, value); }
        }

        /// <summary>
        /// Gets or sets the frame font spacing.
        /// </summary>
        public FontSpacing FrameTitleFontSpacing
        {
            get { return GetNumberProperty<FontSpacing>(NdapiConstants.D2FP_FRAME_TTL_FONT_SPCING); }
            set { SetNumberProperty(NdapiConstants.D2FP_FRAME_TTL_FONT_SPCING, value); }
        }

        /// <summary>
        /// Gets or sets the frame font style.
        /// </summary>
        public FontStyle FrameTitleFontStyle
        {
            get { return GetNumberProperty<FontStyle>(NdapiConstants.D2FP_FRAME_TTL_FONT_STY); }
            set { SetNumberProperty(NdapiConstants.D2FP_FRAME_TTL_FONT_STY, value); }
        }

        /// <summary>
        /// Gets or sets the frame font weight.
        /// </summary>
        public FontWeight FrameTitleFontWeight
        {
            get { return GetNumberProperty<FontWeight>(NdapiConstants.D2FP_FRAME_TTL_FONT_WGHT); }
            set { SetNumberProperty(NdapiConstants.D2FP_FRAME_TTL_FONT_WGHT, value); }
        }

        /// <summary>
        /// Gets or sets the frame title foreground color.
        /// </summary>
        public string FrameTitleForegroundColor
        {
            get { return GetStringProperty(NdapiConstants.D2FP_FRAME_TTL_FORE_COLOR); }
            set { SetStringProperty(NdapiConstants.D2FP_FRAME_TTL_FORE_COLOR, value); }
        }

        /// <summary>
        /// Gets or sets the frame title offset.
        /// </summary>
        public int FrameTitleOffset
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_FRAME_TTL_OFST); }
            set { SetNumberProperty(NdapiConstants.D2FP_FRAME_TTL_OFST, value); }
        }

        /// <summary>
        /// Gets or sets the frame title spacing.
        /// </summary>
        public int FrameTitleSpacing
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_FRAME_TTL_SPCING); }
            set { SetNumberProperty(NdapiConstants.D2FP_FRAME_TTL_SPCING, value); }
        }

        /// <summary>
        /// Gets or sets the frame title visual attribute name.
        /// </summary>
        public string FrameTitleVisualAttributeName
        {
            get { return GetStringProperty(NdapiConstants.D2FP_FRAME_TTL_VAT_NAM); }
            set { SetStringProperty(NdapiConstants.D2FP_FRAME_TTL_VAT_NAM, value); }
        }

        /// <summary>
        /// Gets or sets the graphics object type.
        /// </summary>
        public GraphicsObjectType GraphicsObjectType
        {
            get { return GetNumberProperty<GraphicsObjectType>(NdapiConstants.D2FP_GRAPHICS_TYP); }
            set { SetNumberProperty(NdapiConstants.D2FP_GRAPHICS_TYP, value); }
        }

        /// <summary>
        /// Gets or sets the graphics font color.
        /// </summary>
        public string GraphicsFontColor
        {
            get { return GetStringProperty(NdapiConstants.D2FP_GRA_FONT_COLOR); }
            set { SetStringProperty(NdapiConstants.D2FP_GRA_FONT_COLOR, value); }
        }

        /// <summary>
        /// Gets or sets the graphic's font name.
        /// </summary>
        public string GraphicsFontName
        {
            get { return GetStringProperty(NdapiConstants.D2FP_GRA_FONT_NAM); }
            set { SetStringProperty(NdapiConstants.D2FP_GRA_FONT_NAM, value); }
        }

        /// <summary>
        /// Gets or sets the graphic's font size.
        /// </summary>
        public int GraphicsFontSize
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_GRA_FONT_SIZ); }
            set { SetNumberProperty(NdapiConstants.D2FP_GRA_FONT_SIZ, value); }
        }

        /// <summary>
        /// Gets or sets the graphics font spacing.
        /// </summary>
        public FontSpacing GraphicsFontSpacing
        {
            get { return GetNumberProperty<FontSpacing>(NdapiConstants.D2FP_GRA_FONT_SPCING); }
            set { SetNumberProperty(NdapiConstants.D2FP_GRA_FONT_SPCING, value); }
        }

        /// <summary>
        /// Gets or sets the graphics font style.
        /// </summary>
        public FontStyle GraphicsFontStyle
        {
            get { return GetNumberProperty<FontStyle>(NdapiConstants.D2FP_GRA_FONT_STY); }
            set { SetNumberProperty(NdapiConstants.D2FP_GRA_FONT_STY, value); }
        }

        /// <summary>
        /// Gets or sets the graphics font weight.
        /// </summary>
        public FontWeight GraphicsFontWeight
        {
            get { return GetNumberProperty<FontWeight>(NdapiConstants.D2FP_GRA_FONT_WGHT); }
            set { SetNumberProperty(NdapiConstants.D2FP_GRA_FONT_WGHT, value); }
        }

        /// <summary>
        /// Gets or sets the graphics text.
        /// </summary>
        public string GraphicsText
        {
            get { return GetStringProperty(NdapiConstants.D2FP_GRA_TEXT); }
            set { SetStringProperty(NdapiConstants.D2FP_GRA_TEXT, value); }
        }

        /// <summary>
        /// Gets or sets the height.
        /// </summary>
        public int Height
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_HEIGHT); }
            set { SetNumberProperty(NdapiConstants.D2FP_HEIGHT, value); }
        }

        /// <summary>
        /// Gets or sets the horizontal justification.
        /// </summary>
        public HorizontalJustification HorizontalJustification
        {
            get { return GetNumberProperty<HorizontalJustification>(NdapiConstants.D2FP_HORZ_JST); }
            set { SetNumberProperty(NdapiConstants.D2FP_HORZ_JST, value); }
        }

        /// <summary>
        /// Gets or sets the horizontal margin.
        /// </summary>
        public int HorizontalMargin
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_HORZ_MARGN); }
            set { SetNumberProperty(NdapiConstants.D2FP_HORZ_MARGN, value); }
        }

        /// <summary>
        /// Gets or sets the horizontal object offset.
        /// </summary>
        public int HorizontalObjectOffset
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_HORZ_OBJ_OFST); }
            set { SetNumberProperty(NdapiConstants.D2FP_HORZ_OBJ_OFST, value); }
        }

        /// <summary>
        /// Gets or sets the horizontal position relative to origin.
        /// </summary>
        public int HorizontalPositionRelativeToOrigin
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_HORZ_ORGN); }
            set { SetNumberProperty(NdapiConstants.D2FP_HORZ_ORGN, value); }
        }

        /// <summary>
        /// Gets or sets the joint style.
        /// </summary>
        public JoinStyle JoinStyle
        {
            get { return GetNumberProperty<JoinStyle>(NdapiConstants.D2FP_JOIN_STY); }
            set { SetNumberProperty(NdapiConstants.D2FP_JOIN_STY, value); }
        }

        /// <summary>
        /// Gets or sets the language direction.
        /// </summary>
        public LanguageDirection LanguageDirection
        {
            get { return GetNumberProperty<LanguageDirection>(NdapiConstants.D2FP_LANG_DIR); }
            set { SetNumberProperty(NdapiConstants.D2FP_LANG_DIR, value); }
        }

        /// <summary>
        /// Gets or sets the layout data block.
        /// </summary>
        public string LayoutDataBlock
        {
            get { return GetStringProperty(NdapiConstants.D2FP_LAYOUT_DATA_BLK_NAM); }
            set { SetStringProperty(NdapiConstants.D2FP_LAYOUT_DATA_BLK_NAM, value); }
        }

        /// <summary>
        /// Gets or sets the layout style.
        /// </summary>
        public LayoutStyle LayoutStyle
        {
            get { return GetNumberProperty<LayoutStyle>(NdapiConstants.D2FP_LAYOUT_STY); }
            set { SetNumberProperty(NdapiConstants.D2FP_LAYOUT_STY, value); }
        }

        /// <summary>
        /// Gets or sets the line spacing.
        /// </summary>
        public LineSpacing LineSpacing
        {
            get { return GetNumberProperty<LineSpacing>(NdapiConstants.D2FP_LIN_SPCING); }
            set { SetNumberProperty(NdapiConstants.D2FP_LIN_SPCING, value); }
        }

        /// <summary>
        /// Gets or sets the maximum number of objects per line.
        /// </summary>
        public int MaximumObjectsPerLine
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_MAX_OBJS); }
            set { SetNumberProperty(NdapiConstants.D2FP_MAX_OBJS, value); }
        }

        /// <summary>
        /// Gets or sets the number of records displayed.
        /// </summary>
        public int NumberOfRecordsDisplayed
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_RECS_DISP_COUNT); }
            set { SetNumberProperty(NdapiConstants.D2FP_RECS_DISP_COUNT, value); }
        }

        /// <summary>
        /// Gets or sets the scrollbar alignment.
        /// </summary>
        public ScrollBarAlignment ScrollBarAlignment
        {
            get { return GetNumberProperty<ScrollBarAlignment>(NdapiConstants.D2FP_SCRLBR_ALIGN); }
            set { SetNumberProperty(NdapiConstants.D2FP_SCRLBR_ALIGN, value); }
        }

        /// <summary>
        /// Gets or sets the scrollbar width.
        /// </summary>
        public int ScrollBarWidth
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_SCRLBR_WID); }
            set { SetNumberProperty(NdapiConstants.D2FP_SCRLBR_WID, value); }
        }

        /// <summary>
        /// Gets or sets whether runtime should create a block scrollbar for the graphics.
        /// </summary>
        public bool ShowScrollBar
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_SHOW_SCRLBR); }
            set { SetBooleanProperty(NdapiConstants.D2FP_SHOW_SCRLBR, value); }
        }

        /// <summary>
        /// Gets or sets whether blank space should be automatically removed from the frame.
        /// </summary>
        public bool Shrinkwrap
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_SHRINKWRAP); }
            set { SetBooleanProperty(NdapiConstants.D2FP_SHRINKWRAP, value); }
        }

        /// <summary>
        /// Gets or sets the single object alignment when the <see cref="FrameAlignment"/> is set to <see cref="FrameAlignment.Fill"/>.
        /// </summary>
        public Alignment SingleObjectAlignment
        {
            get { return GetNumberProperty<Alignment>(NdapiConstants.D2FP_SNGL_OBJ_ALIGN); }
            set { SetNumberProperty(NdapiConstants.D2FP_SNGL_OBJ_ALIGN, value); }
        }

        /// <summary>
        /// Gets or sets the start prompt alignment.
        /// </summary>
        public Alignment StartPromptAlignment
        {
            get { return GetNumberProperty<Alignment>(NdapiConstants.D2FP_STRT_PRMPT_ALIGN); }
            set { SetNumberProperty(NdapiConstants.D2FP_STRT_PRMPT_ALIGN, value); }
        }

        /// <summary>
        /// Gets or sets the start prompt offset.
        /// </summary>
        public int StartPromptOffset
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_STRT_PRMPT_OFST); }
            set { SetNumberProperty(NdapiConstants.D2FP_STRT_PRMPT_OFST, value); }
        }

        /// <summary>
        /// Gets or sets the top prompt alignment.
        /// </summary>
        public Alignment TopPromptAlignment
        {
            get { return GetNumberProperty<Alignment>(NdapiConstants.D2FP_TOP_PRMPT_ALIGN); }
            set { SetNumberProperty(NdapiConstants.D2FP_TOP_PRMPT_ALIGN, value); }
        }

        /// <summary>
        /// Gets or sets the top prompt offset.
        /// </summary>
        public int TopPromptOffset
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_TOP_PRMPT_OFST); }
            set { SetNumberProperty(NdapiConstants.D2FP_TOP_PRMPT_OFST, value); }
        }

        /// <summary>
        /// Gets or sets the title reading order,
        /// </summary>
        public ReadingOrder TitleReadingOrder
        {
            get { return GetNumberProperty<ReadingOrder>(NdapiConstants.D2FP_TTL_READING_ORDR); }
            set { SetNumberProperty(NdapiConstants.D2FP_TTL_READING_ORDR, value); }
        }

        /// <summary>
        /// Gets or sets the update layout mode.
        /// </summary>
        public UpdateLayout UpdateLayout
        {
            get { return GetNumberProperty<UpdateLayout>(NdapiConstants.D2FP_UPDT_LAYOUT); }
            set { SetNumberProperty(NdapiConstants.D2FP_UPDT_LAYOUT, value); }
        }

        /// <summary>
        /// Gets or sets the visual attribute name.
        /// </summary>
        public string VisualAttributeName
        {
            get { return GetStringProperty(NdapiConstants.D2FP_VAT_NAM); }
            set { SetStringProperty(NdapiConstants.D2FP_VAT_NAM, value); }
        }

        /// <summary>
        /// Gets or sets whether the runtime uses the empty space surrounding an object when the <see cref="LayoutStyle"/> is set to <see cref="LayoutStyle.Form"/>.
        /// </summary>
        public bool VerticalFill
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_VERT_FILL); }
            set { SetBooleanProperty(NdapiConstants.D2FP_VERT_FILL, value); }
        }

        /// <summary>
        /// Gets or sets the vertical justification.
        /// </summary>
        public VerticalJustification VerticalJustification
        {
            get { return GetNumberProperty<VerticalJustification>(NdapiConstants.D2FP_VERT_JST); }
            set { SetNumberProperty(NdapiConstants.D2FP_VERT_JST, value); }
        }

        /// <summary>
        /// Gets or sets the vertical margin.
        /// </summary>
        public int VerticalMargin
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_VERT_MARGN); }
            set { SetNumberProperty(NdapiConstants.D2FP_VERT_MARGN, value); }
        }

        /// <summary>
        /// Gets or sets the vertical object offset.
        /// </summary>
        public int VerticalObjectOffset
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_VERT_OBJ_OFST); }
            set { SetNumberProperty(NdapiConstants.D2FP_VERT_OBJ_OFST, value); }
        }

        /// <summary>
        /// Gets or sets the vertical position relative to origin.
        /// </summary>
        public int VerticalPositionRelativeToOrigin
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_VERT_ORGN); }
            set { SetNumberProperty(NdapiConstants.D2FP_VERT_ORGN, value); }
        }

        /// <summary>
        /// Gets or sets the width.
        /// </summary>
        public int Width
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_WIDTH); }
            set { SetNumberProperty(NdapiConstants.D2FP_WIDTH, value); }
        }

        /// <summary>
        /// Gets or sets whether runtime should wrap text.
        /// </summary>
        public bool WrapText
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_WRAP_TXT); }
            set { SetBooleanProperty(NdapiConstants.D2FP_WRAP_TXT, value); }
        }

        /// <summary>
        /// Gets or sets the X position measured at the upper left corner.
        /// </summary>
        public int XPosition
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_X_POS); }
            set { SetNumberProperty(NdapiConstants.D2FP_X_POS, value); }
        }

        /// <summary>
        /// Gets or sets the Y position measured at the upper left corner.
        /// </summary>
        public int YPosition
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_Y_POS); }
            set { SetNumberProperty(NdapiConstants.D2FP_Y_POS, value); }
        }

        /// <summary>
        /// Gets the font point size.
        /// </summary>
        public NdapiObject FontPointSize
        {
            get { return GetObjectProperty<NdapiObject>(NdapiConstants.D2FP_POINT); }
        }

        /// <summary>
        /// Gets or sets the child graphics.
        /// </summary>
        public IEnumerable<Graphics> ChildGraphics => GetObjectList<Graphics>(NdapiConstants.D2FP_GRAPHIC);

        /// <summary>
        /// Imports an image from disk into a graphics image object.
        /// </summary>
        /// <param name="filename">Image path.</param>
        /// <param name="format">Image format.</param>
        public void ImportImage(string filename, ImageFormat format)
        {
            var status = NativeMethods.d2fgraim_importImage(NdapiContext.Context, _handle, filename, format);
            Ensure.Success(status);
        }
    }
}