using System;
using System.Collections.Generic;

namespace PersonalWork.Infrastructure.DevDB;

public partial class ProductList
{
    public int ProductId { get; set; }

    public int BatchId { get; set; }

    public string? Name { get; set; }

    public string? Enname { get; set; }

    public string? RuName { get; set; }

    public string? EsName { get; set; }

    public string? Imgurl { get; set; }

    public decimal? Price { get; set; }

    public string? SmallImagurl { get; set; }

    public decimal? AddCount { get; set; }

    public decimal? BoxCount { get; set; }

    public decimal? TotalPcs { get; set; }

    public decimal? TotalGw { get; set; }

    public decimal? TotalCbm { get; set; }

    public decimal? TotalNw { get; set; }

    public string? ProductCode { get; set; }

    public int? ProductModelId { get; set; }

    public string? ProductModelName { get; set; }

    public string? ProductTypeName { get; set; }

    public int? ProductTypeId { get; set; }

    public decimal? BoxSize01 { get; set; }

    public decimal? BoxSize02 { get; set; }

    public decimal? BoxSize03 { get; set; }

    public decimal? BoxSizeSum { get; set; }

    public string? BoxSize { get; set; }

    public decimal? SampleSize01 { get; set; }

    public decimal? SampleSize02 { get; set; }

    public decimal? SampleSize03 { get; set; }

    public string? SampleSize { get; set; }

    public int? PakingTypeId { get; set; }

    public string? PakingTypeName { get; set; }

    public decimal? Nw { get; set; }

    public decimal? Gw { get; set; }

    public decimal? Pcs { get; set; }

    public decimal? Cntcbm { get; set; }

    public string? Ceritficate { get; set; }

    public bool? IsZh { get; set; }

    public bool? IsEn { get; set; }

    public bool? IsRu { get; set; }

    public bool? IsEs { get; set; }

    public string? Bhdes { get; set; }

    public DateTime? LastUpdate { get; set; }

    public string? FacPno { get; set; }

    public int? ShowPrice { get; set; }

    public string? FactoryCode { get; set; }

    public string? FactoryName { get; set; }

    public string? DetailDescription { get; set; }

    public string? ProductState { get; set; }

    public string? FacCode { get; set; }

    public decimal? PurchasePrice { get; set; }

    public decimal? MeterialArea { get; set; }

    public string? VideoUrl { get; set; }

    public string? ProductVideo { get; set; }

    public int? Id { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? Weight { get; set; }

    public bool? IsActive { get; set; }
}
