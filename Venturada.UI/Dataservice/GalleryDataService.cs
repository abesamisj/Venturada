using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Venturada.UI.Models;

namespace Venturada.UI.Dataservice
{
    public class GalleryDataService
    {
        public List<GalleryModel> GenerateGalleryByRow(int row)
        {
            List<GalleryModel> modelList = new List<GalleryModel>();
            GalleryModel model = new GalleryModel();
            try
            {
                using (VenturadaDataContext vdc = new VenturadaDataContext())
                {
                    var tableList = from p in vdc.Galleries.ToList()
                                    where p.Row == row
                                    orderby p.GalleryId ascending
                                    select p;
                    foreach (var item in tableList)
                    {
                        model = new GalleryModel();
                        model.GalleryId = item.GalleryId;
                        model.GalleryDescription = item.GalleryDescription;
                        model.GalleryTitle = item.GalleryTitle;
                        model.Row = item.Row;
                        model.ImageString = item.ImageString;
                        modelList.Add(model);
                    }


                    return modelList;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void InsertGallery(GalleryModel model)
        {
            try
            {
                int row = 0;
                using (VenturadaDataContext vdc = new VenturadaDataContext())
                {
                    var tableList = from p in vdc.Galleries.ToList()
                                    where p.Row == 1
                                    select p;

                    if (tableList.ToList().Count <= 3)
                    {
                        row = 1;
                    }

                    var tableList2 = from p in vdc.Galleries.ToList()
                                     where p.Row == 2
                                     select p;

                    if (tableList2.ToList().Count <= 3 && tableList.ToList().Count == 3)
                    {
                        row = 2;
                    }

                    var tableList3 = from p in vdc.Galleries.ToList()
                                     where p.Row == 3
                                     select p;

                    if (tableList3.ToList().Count <= 3 && tableList.ToList().Count == 3 && tableList2.ToList().Count == 3)
                    {
                        row = 3;
                    }

                    var tableList4 = from p in vdc.Galleries.ToList()
                                     where p.Row == 4
                                     select p;

                    if (tableList4.ToList().Count <= 3 && tableList.ToList().Count == 3 && tableList2.ToList().Count == 3 && tableList3.ToList().Count == 3)
                    {
                        row = 4;
                    }

                    var tableList5 = from p in vdc.Galleries.ToList()
                                     where p.Row == 5
                                     select p;

                    if (tableList5.ToList().Count <= 3 && tableList.ToList().Count == 3 && tableList2.ToList().Count == 3 && tableList3.ToList().Count == 3 && tableList4.ToList().Count == 3)
                    {
                        row = 5;
                    }

                    var tableList6 = from p in vdc.Galleries.ToList()
                                     where p.Row == 6
                                     select p;

                    if (tableList6.ToList().Count <= 3 && tableList.ToList().Count == 3 && tableList2.ToList().Count == 3 && tableList3.ToList().Count == 3 && tableList4.ToList().Count == 3 && tableList5.ToList().Count == 3)
                    {
                        row = 6;
                    }

                    var tableList7 = from p in vdc.Galleries.ToList()
                                     where p.Row == 7
                                     select p;

                    if (tableList6.ToList().Count <= 3 && tableList.ToList().Count == 3 && tableList2.ToList().Count == 3 && tableList3.ToList().Count == 3 && tableList4.ToList().Count == 3 && tableList5.ToList().Count == 3 && tableList6.ToList().Count == 3)
                    {
                        row = 7;
                    }

                    var tableList8 = from p in vdc.Galleries.ToList()
                                     where p.Row == 8
                                     select p;

                    if (tableList8.ToList().Count <= 3 && tableList.ToList().Count == 3 && tableList2.ToList().Count == 3 && tableList3.ToList().Count == 3 && tableList4.ToList().Count == 3 && tableList5.ToList().Count == 3 && tableList6.ToList().Count == 3 && tableList7.ToList().Count == 3)
                    {
                        row = 8;
                    }

                    var tableList9 = from p in vdc.Galleries.ToList()
                                     where p.Row == 9
                                     select p;

                    if (tableList9.ToList().Count <= 3 
                        && tableList.ToList().Count == 3 
                        && tableList2.ToList().Count == 3 
                        && tableList3.ToList().Count == 3 
                        && tableList4.ToList().Count == 3 
                        && tableList5.ToList().Count == 3 
                        && tableList6.ToList().Count == 3 
                        && tableList7.ToList().Count == 3 
                        && tableList8.ToList().Count == 3)
                    {
                        row = 9;
                    }

                    var tableList10 = from p in vdc.Galleries.ToList()
                                     where p.Row == 10
                                     select p;

                    if (tableList10.ToList().Count <= 3
                        && tableList.ToList().Count == 3
                        && tableList2.ToList().Count == 3
                        && tableList3.ToList().Count == 3
                        && tableList4.ToList().Count == 3
                        && tableList5.ToList().Count == 3
                        && tableList6.ToList().Count == 3
                        && tableList7.ToList().Count == 3
                        && tableList8.ToList().Count == 3
                        && tableList9.ToList().Count == 3)
                    {
                        row = 10;
                    }

                    var tableList11 = from p in vdc.Galleries.ToList()
                                      where p.Row == 11
                                      select p;

                    if (tableList11.ToList().Count <= 3
                        && tableList.ToList().Count == 3
                        && tableList2.ToList().Count == 3
                        && tableList3.ToList().Count == 3
                        && tableList4.ToList().Count == 3
                        && tableList5.ToList().Count == 3
                        && tableList6.ToList().Count == 3
                        && tableList7.ToList().Count == 3
                        && tableList8.ToList().Count == 3
                        && tableList9.ToList().Count == 3
                        && tableList10.ToList().Count == 3)
                    {
                        row = 11;
                    }

                    var tableList12 = from p in vdc.Galleries.ToList()
                                      where p.Row == 12
                                      select p;

                    if (tableList12.ToList().Count <= 3
                        && tableList.ToList().Count == 3
                        && tableList2.ToList().Count == 3
                        && tableList3.ToList().Count == 3
                        && tableList4.ToList().Count == 3
                        && tableList5.ToList().Count == 3
                        && tableList6.ToList().Count == 3
                        && tableList7.ToList().Count == 3
                        && tableList8.ToList().Count == 3
                        && tableList9.ToList().Count == 3
                        && tableList10.ToList().Count == 3
                        && tableList11.ToList().Count == 3)
                    {
                        row = 12;
                    }

                    var tableList13 = from p in vdc.Galleries.ToList()
                                      where p.Row == 13
                                      select p;

                    if (tableList13.ToList().Count <= 3
                        && tableList.ToList().Count == 3
                        && tableList2.ToList().Count == 3
                        && tableList3.ToList().Count == 3
                        && tableList4.ToList().Count == 3
                        && tableList5.ToList().Count == 3
                        && tableList6.ToList().Count == 3
                        && tableList7.ToList().Count == 3
                        && tableList8.ToList().Count == 3
                        && tableList9.ToList().Count == 3
                        && tableList10.ToList().Count == 3
                        && tableList11.ToList().Count == 3
                        && tableList12.ToList().Count == 3)
                    {
                        row = 13;
                    }

                    var tableList14 = from p in vdc.Galleries.ToList()
                                      where p.Row == 14
                                      select p;

                    if (tableList14.ToList().Count <= 3
                        && tableList.ToList().Count == 3
                        && tableList2.ToList().Count == 3
                        && tableList3.ToList().Count == 3
                        && tableList4.ToList().Count == 3
                        && tableList5.ToList().Count == 3
                        && tableList6.ToList().Count == 3
                        && tableList7.ToList().Count == 3
                        && tableList8.ToList().Count == 3
                        && tableList9.ToList().Count == 3
                        && tableList10.ToList().Count == 3
                        && tableList11.ToList().Count == 3
                        && tableList12.ToList().Count == 3
                        && tableList13.ToList().Count == 3)
                    {
                        row = 14;
                    }

                    var tableList15 = from p in vdc.Galleries.ToList()
                                      where p.Row == 15
                                      select p;

                    if (tableList15.ToList().Count <= 3
                        && tableList.ToList().Count == 3
                        && tableList2.ToList().Count == 3
                        && tableList3.ToList().Count == 3
                        && tableList4.ToList().Count == 3
                        && tableList5.ToList().Count == 3
                        && tableList6.ToList().Count == 3
                        && tableList7.ToList().Count == 3
                        && tableList8.ToList().Count == 3
                        && tableList9.ToList().Count == 3
                        && tableList10.ToList().Count == 3
                        && tableList11.ToList().Count == 3
                        && tableList12.ToList().Count == 3
                        && tableList13.ToList().Count == 3
                        && tableList14.ToList().Count == 3)
                    {
                        row = 15;
                    }

                    var tableList16 = from p in vdc.Galleries.ToList()
                                      where p.Row == 16
                                      select p;

                    if (tableList16.ToList().Count <= 3
                        && tableList.ToList().Count == 3
                        && tableList2.ToList().Count == 3
                        && tableList3.ToList().Count == 3
                        && tableList4.ToList().Count == 3
                        && tableList5.ToList().Count == 3
                        && tableList6.ToList().Count == 3
                        && tableList7.ToList().Count == 3
                        && tableList8.ToList().Count == 3
                        && tableList9.ToList().Count == 3
                        && tableList10.ToList().Count == 3
                        && tableList11.ToList().Count == 3
                        && tableList12.ToList().Count == 3
                        && tableList13.ToList().Count == 3
                        && tableList14.ToList().Count == 3
                        && tableList15.ToList().Count == 3)
                    {
                        row = 16;
                    }

                    var tableList17 = from p in vdc.Galleries.ToList()
                                      where p.Row == 17
                                      select p;

                    if (tableList17.ToList().Count <= 3
                        && tableList.ToList().Count == 3
                        && tableList2.ToList().Count == 3
                        && tableList3.ToList().Count == 3
                        && tableList4.ToList().Count == 3
                        && tableList5.ToList().Count == 3
                        && tableList6.ToList().Count == 3
                        && tableList7.ToList().Count == 3
                        && tableList8.ToList().Count == 3
                        && tableList9.ToList().Count == 3
                        && tableList10.ToList().Count == 3
                        && tableList11.ToList().Count == 3
                        && tableList12.ToList().Count == 3
                        && tableList13.ToList().Count == 3
                        && tableList14.ToList().Count == 3
                        && tableList15.ToList().Count == 3
                        && tableList16.ToList().Count == 3)
                    {
                        row = 17;
                    }

                    var tableList18 = from p in vdc.Galleries.ToList()
                                      where p.Row == 18
                                      select p;

                    if (tableList18.ToList().Count <= 3
                        && tableList.ToList().Count == 3
                        && tableList2.ToList().Count == 3
                        && tableList3.ToList().Count == 3
                        && tableList4.ToList().Count == 3
                        && tableList5.ToList().Count == 3
                        && tableList6.ToList().Count == 3
                        && tableList7.ToList().Count == 3
                        && tableList8.ToList().Count == 3
                        && tableList9.ToList().Count == 3
                        && tableList10.ToList().Count == 3
                        && tableList11.ToList().Count == 3
                        && tableList12.ToList().Count == 3
                        && tableList13.ToList().Count == 3
                        && tableList14.ToList().Count == 3
                        && tableList15.ToList().Count == 3
                        && tableList16.ToList().Count == 3
                        && tableList17.ToList().Count == 3)
                    {
                        row = 18;
                    }

                    var tableList19 = from p in vdc.Galleries.ToList()
                                      where p.Row == 19
                                      select p;

                    if (tableList19.ToList().Count <= 3
                        && tableList.ToList().Count == 3
                        && tableList2.ToList().Count == 3
                        && tableList3.ToList().Count == 3
                        && tableList4.ToList().Count == 3
                        && tableList5.ToList().Count == 3
                        && tableList6.ToList().Count == 3
                        && tableList7.ToList().Count == 3
                        && tableList8.ToList().Count == 3
                        && tableList9.ToList().Count == 3
                        && tableList10.ToList().Count == 3
                        && tableList11.ToList().Count == 3
                        && tableList12.ToList().Count == 3
                        && tableList13.ToList().Count == 3
                        && tableList14.ToList().Count == 3
                        && tableList15.ToList().Count == 3
                        && tableList16.ToList().Count == 3
                        && tableList17.ToList().Count == 3
                        && tableList18.ToList().Count == 3)
                    {
                        row = 19;
                    }

                    var tableList20 = from p in vdc.Galleries.ToList()
                                      where p.Row == 20
                                      select p;

                    if (tableList20.ToList().Count <= 3
                        && tableList.ToList().Count == 3
                        && tableList2.ToList().Count == 3
                        && tableList3.ToList().Count == 3
                        && tableList4.ToList().Count == 3
                        && tableList5.ToList().Count == 3
                        && tableList6.ToList().Count == 3
                        && tableList7.ToList().Count == 3
                        && tableList8.ToList().Count == 3
                        && tableList9.ToList().Count == 3
                        && tableList10.ToList().Count == 3
                        && tableList11.ToList().Count == 3
                        && tableList12.ToList().Count == 3
                        && tableList13.ToList().Count == 3
                        && tableList14.ToList().Count == 3
                        && tableList15.ToList().Count == 3
                        && tableList16.ToList().Count == 3
                        && tableList17.ToList().Count == 3
                        && tableList18.ToList().Count == 3 
                        && tableList19.ToList().Count == 3)
                    {
                        row = 20;
                    }

                    var tableList21 = from p in vdc.Galleries.ToList()
                                      where p.Row == 21
                                      select p;

                    if (tableList21.ToList().Count <= 3
                        && tableList.ToList().Count == 3
                        && tableList2.ToList().Count == 3
                        && tableList3.ToList().Count == 3
                        && tableList4.ToList().Count == 3
                        && tableList5.ToList().Count == 3
                        && tableList6.ToList().Count == 3
                        && tableList7.ToList().Count == 3
                        && tableList8.ToList().Count == 3
                        && tableList9.ToList().Count == 3
                        && tableList10.ToList().Count == 3
                        && tableList11.ToList().Count == 3
                        && tableList12.ToList().Count == 3
                        && tableList13.ToList().Count == 3
                        && tableList14.ToList().Count == 3
                        && tableList15.ToList().Count == 3
                        && tableList16.ToList().Count == 3
                        && tableList17.ToList().Count == 3
                        && tableList18.ToList().Count == 3
                        && tableList19.ToList().Count == 3 
                        && tableList20.ToList().Count == 3)
                    {
                        row = 21;
                    }

                    var tableList22 = from p in vdc.Galleries.ToList()
                                      where p.Row == 22
                                      select p;

                    if (tableList22.ToList().Count <= 3
                        && tableList.ToList().Count == 3
                        && tableList2.ToList().Count == 3
                        && tableList3.ToList().Count == 3
                        && tableList4.ToList().Count == 3
                        && tableList5.ToList().Count == 3
                        && tableList6.ToList().Count == 3
                        && tableList7.ToList().Count == 3
                        && tableList8.ToList().Count == 3
                        && tableList9.ToList().Count == 3
                        && tableList10.ToList().Count == 3
                        && tableList11.ToList().Count == 3
                        && tableList12.ToList().Count == 3
                        && tableList13.ToList().Count == 3
                        && tableList14.ToList().Count == 3
                        && tableList15.ToList().Count == 3
                        && tableList16.ToList().Count == 3
                        && tableList17.ToList().Count == 3
                        && tableList18.ToList().Count == 3
                        && tableList19.ToList().Count == 3
                        && tableList20.ToList().Count == 3
                        && tableList21.ToList().Count == 3)
                    {
                        row = 22;
                    }

                    var tableList23 = from p in vdc.Galleries.ToList()
                                      where p.Row == 23
                                      select p;

                    if (tableList23.ToList().Count <= 3
                        && tableList.ToList().Count == 3
                        && tableList2.ToList().Count == 3
                        && tableList3.ToList().Count == 3
                        && tableList4.ToList().Count == 3
                        && tableList5.ToList().Count == 3
                        && tableList6.ToList().Count == 3
                        && tableList7.ToList().Count == 3
                        && tableList8.ToList().Count == 3
                        && tableList9.ToList().Count == 3
                        && tableList10.ToList().Count == 3
                        && tableList11.ToList().Count == 3
                        && tableList12.ToList().Count == 3
                        && tableList13.ToList().Count == 3
                        && tableList14.ToList().Count == 3
                        && tableList15.ToList().Count == 3
                        && tableList16.ToList().Count == 3
                        && tableList17.ToList().Count == 3
                        && tableList18.ToList().Count == 3
                        && tableList19.ToList().Count == 3
                        && tableList20.ToList().Count == 3
                        && tableList21.ToList().Count == 3
                        && tableList22.ToList().Count == 3)
                    {
                        row = 23;
                    }

                    var tableList24 = from p in vdc.Galleries.ToList()
                                      where p.Row == 24
                                      select p;

                    if (tableList24.ToList().Count <= 3
                        && tableList.ToList().Count == 3
                        && tableList2.ToList().Count == 3
                        && tableList3.ToList().Count == 3
                        && tableList4.ToList().Count == 3
                        && tableList5.ToList().Count == 3
                        && tableList6.ToList().Count == 3
                        && tableList7.ToList().Count == 3
                        && tableList8.ToList().Count == 3
                        && tableList9.ToList().Count == 3
                        && tableList10.ToList().Count == 3
                        && tableList11.ToList().Count == 3
                        && tableList12.ToList().Count == 3
                        && tableList13.ToList().Count == 3
                        && tableList14.ToList().Count == 3
                        && tableList15.ToList().Count == 3
                        && tableList16.ToList().Count == 3
                        && tableList17.ToList().Count == 3
                        && tableList18.ToList().Count == 3
                        && tableList19.ToList().Count == 3
                        && tableList20.ToList().Count == 3
                        && tableList21.ToList().Count == 3
                        && tableList22.ToList().Count == 3
                        && tableList23.ToList().Count == 3)
                    {
                        row = 24;
                    }

                    var tableList25 = from p in vdc.Galleries.ToList()
                                      where p.Row == 25
                                      select p;

                    if (tableList25.ToList().Count <= 3
                        && tableList.ToList().Count == 3
                        && tableList2.ToList().Count == 3
                        && tableList3.ToList().Count == 3
                        && tableList4.ToList().Count == 3
                        && tableList5.ToList().Count == 3
                        && tableList6.ToList().Count == 3
                        && tableList7.ToList().Count == 3
                        && tableList8.ToList().Count == 3
                        && tableList9.ToList().Count == 3
                        && tableList10.ToList().Count == 3
                        && tableList11.ToList().Count == 3
                        && tableList12.ToList().Count == 3
                        && tableList13.ToList().Count == 3
                        && tableList14.ToList().Count == 3
                        && tableList15.ToList().Count == 3
                        && tableList16.ToList().Count == 3
                        && tableList17.ToList().Count == 3
                        && tableList18.ToList().Count == 3
                        && tableList19.ToList().Count == 3
                        && tableList20.ToList().Count == 3
                        && tableList21.ToList().Count == 3
                        && tableList22.ToList().Count == 3
                        && tableList23.ToList().Count == 3
                        && tableList24.ToList().Count == 3)
                    {
                        row = 25;
                    }

                    var tableList26 = from p in vdc.Galleries.ToList()
                                      where p.Row == 26
                                      select p;

                    if (tableList26.ToList().Count <= 3
                        && tableList.ToList().Count == 3
                        && tableList2.ToList().Count == 3
                        && tableList3.ToList().Count == 3
                        && tableList4.ToList().Count == 3
                        && tableList5.ToList().Count == 3
                        && tableList6.ToList().Count == 3
                        && tableList7.ToList().Count == 3
                        && tableList8.ToList().Count == 3
                        && tableList9.ToList().Count == 3
                        && tableList10.ToList().Count == 3
                        && tableList11.ToList().Count == 3
                        && tableList12.ToList().Count == 3
                        && tableList13.ToList().Count == 3
                        && tableList14.ToList().Count == 3
                        && tableList15.ToList().Count == 3
                        && tableList16.ToList().Count == 3
                        && tableList17.ToList().Count == 3
                        && tableList18.ToList().Count == 3
                        && tableList19.ToList().Count == 3
                        && tableList20.ToList().Count == 3
                        && tableList21.ToList().Count == 3
                        && tableList22.ToList().Count == 3
                        && tableList23.ToList().Count == 3
                        && tableList24.ToList().Count == 3
                        && tableList25.ToList().Count == 3)
                    {
                        row = 26;
                    }

                    var tableList27 = from p in vdc.Galleries.ToList()
                                      where p.Row == 27
                                      select p;

                    if (tableList27.ToList().Count <= 3
                        && tableList.ToList().Count == 3
                        && tableList2.ToList().Count == 3
                        && tableList3.ToList().Count == 3
                        && tableList4.ToList().Count == 3
                        && tableList5.ToList().Count == 3
                        && tableList6.ToList().Count == 3
                        && tableList7.ToList().Count == 3
                        && tableList8.ToList().Count == 3
                        && tableList9.ToList().Count == 3
                        && tableList10.ToList().Count == 3
                        && tableList11.ToList().Count == 3
                        && tableList12.ToList().Count == 3
                        && tableList13.ToList().Count == 3
                        && tableList14.ToList().Count == 3
                        && tableList15.ToList().Count == 3
                        && tableList16.ToList().Count == 3
                        && tableList17.ToList().Count == 3
                        && tableList18.ToList().Count == 3
                        && tableList19.ToList().Count == 3
                        && tableList20.ToList().Count == 3
                        && tableList21.ToList().Count == 3
                        && tableList22.ToList().Count == 3
                        && tableList23.ToList().Count == 3
                        && tableList24.ToList().Count == 3
                        && tableList25.ToList().Count == 3
                        && tableList26.ToList().Count == 3)
                    {
                        row = 27;
                    }

                    var tableList28 = from p in vdc.Galleries.ToList()
                                      where p.Row == 28
                                      select p;

                    if (tableList28.ToList().Count <= 3
                        && tableList.ToList().Count == 3
                        && tableList2.ToList().Count == 3
                        && tableList3.ToList().Count == 3
                        && tableList4.ToList().Count == 3
                        && tableList5.ToList().Count == 3
                        && tableList6.ToList().Count == 3
                        && tableList7.ToList().Count == 3
                        && tableList8.ToList().Count == 3
                        && tableList9.ToList().Count == 3
                        && tableList10.ToList().Count == 3
                        && tableList11.ToList().Count == 3
                        && tableList12.ToList().Count == 3
                        && tableList13.ToList().Count == 3
                        && tableList14.ToList().Count == 3
                        && tableList15.ToList().Count == 3
                        && tableList16.ToList().Count == 3
                        && tableList17.ToList().Count == 3
                        && tableList18.ToList().Count == 3
                        && tableList19.ToList().Count == 3
                        && tableList20.ToList().Count == 3
                        && tableList21.ToList().Count == 3
                        && tableList22.ToList().Count == 3
                        && tableList23.ToList().Count == 3
                        && tableList24.ToList().Count == 3
                        && tableList25.ToList().Count == 3
                        && tableList26.ToList().Count == 3
                        && tableList27.ToList().Count == 3)
                    {
                        row = 28;
                    }

                    var tableList29 = from p in vdc.Galleries.ToList()
                                      where p.Row == 29
                                      select p;

                    if (tableList29.ToList().Count <= 3
                        && tableList.ToList().Count == 3
                        && tableList2.ToList().Count == 3
                        && tableList3.ToList().Count == 3
                        && tableList4.ToList().Count == 3
                        && tableList5.ToList().Count == 3
                        && tableList6.ToList().Count == 3
                        && tableList7.ToList().Count == 3
                        && tableList8.ToList().Count == 3
                        && tableList9.ToList().Count == 3
                        && tableList10.ToList().Count == 3
                        && tableList11.ToList().Count == 3
                        && tableList12.ToList().Count == 3
                        && tableList13.ToList().Count == 3
                        && tableList14.ToList().Count == 3
                        && tableList15.ToList().Count == 3
                        && tableList16.ToList().Count == 3
                        && tableList17.ToList().Count == 3
                        && tableList18.ToList().Count == 3
                        && tableList19.ToList().Count == 3
                        && tableList20.ToList().Count == 3
                        && tableList21.ToList().Count == 3
                        && tableList22.ToList().Count == 3
                        && tableList23.ToList().Count == 3
                        && tableList24.ToList().Count == 3
                        && tableList25.ToList().Count == 3
                        && tableList26.ToList().Count == 3
                        && tableList27.ToList().Count == 3
                        && tableList28.ToList().Count == 3)
                    {
                        row = 29;
                    }
                    var tableList30 = from p in vdc.Galleries.ToList()
                                      where p.Row == 30
                                      select p;

                    if (tableList30.ToList().Count <= 3
                        && tableList.ToList().Count == 3
                        && tableList2.ToList().Count == 3
                        && tableList3.ToList().Count == 3
                        && tableList4.ToList().Count == 3
                        && tableList5.ToList().Count == 3
                        && tableList6.ToList().Count == 3
                        && tableList7.ToList().Count == 3
                        && tableList8.ToList().Count == 3
                        && tableList9.ToList().Count == 3
                        && tableList10.ToList().Count == 3
                        && tableList11.ToList().Count == 3
                        && tableList12.ToList().Count == 3
                        && tableList13.ToList().Count == 3
                        && tableList14.ToList().Count == 3
                        && tableList15.ToList().Count == 3
                        && tableList16.ToList().Count == 3
                        && tableList17.ToList().Count == 3
                        && tableList18.ToList().Count == 3
                        && tableList19.ToList().Count == 3
                        && tableList20.ToList().Count == 3
                        && tableList21.ToList().Count == 3
                        && tableList22.ToList().Count == 3
                        && tableList23.ToList().Count == 3
                        && tableList24.ToList().Count == 3
                        && tableList25.ToList().Count == 3
                        && tableList26.ToList().Count == 3
                        && tableList27.ToList().Count == 3
                        && tableList28.ToList().Count == 3
                        && tableList29.ToList().Count == 3)
                    {
                        row = 30;
                    }
                }


                using (VenturadaDataContext vdc = new VenturadaDataContext())
                {
                    Gallery table = new Gallery();
                    table.GalleryTitle = model.GalleryTitle;
                    table.GalleryDescription = model.GalleryDescription;
                    table.ImageString = model.ImageString;
                    table.Row = row;

                    vdc.Galleries.InsertOnSubmit(table);
                    vdc.SubmitChanges();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void DeleteGallery(int galleryId)
        {
            try
            {

                using (VenturadaDataContext vdc = new VenturadaDataContext())
                {
                    var remove = (from aremove in vdc.Galleries
                                  where aremove.GalleryId == galleryId
                                  select aremove).FirstOrDefault();

                    if (remove != null)
                    {
                        vdc.Galleries.DeleteOnSubmit(remove);
                        vdc.SubmitChanges();
                    }
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public GalleryModel GetGalleryById(int id)
        {
            GalleryModel model = new GalleryModel();
            try
            {
                using (VenturadaDataContext vdc = new VenturadaDataContext())
                {
                    var tableList = from p in vdc.Galleries.ToList()
                                    where p.GalleryId == id
                                    orderby p.GalleryId ascending
                                    select p;

                    model = new GalleryModel();
                    model.GalleryId = tableList.FirstOrDefault().GalleryId;
                    model.GalleryDescription = tableList.FirstOrDefault().GalleryDescription;
                    model.GalleryTitle = tableList.FirstOrDefault().GalleryTitle;
                    model.ImageString = tableList.FirstOrDefault().ImageString;

                    return model;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void UpdateGallery(GalleryModel model)
        {
            try
            {
                Gallery table = new Gallery();
                using (VenturadaDataContext vdc = new VenturadaDataContext())
                {
                    table = vdc.Galleries.Single(a => a.GalleryId == model.GalleryId);
                    table.GalleryId = model.GalleryId;
                    table.GalleryTitle = model.GalleryTitle;
                    table.GalleryDescription = model.GalleryDescription;
                    table.ImageString = model.ImageString;
                    vdc.SubmitChanges();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}