//// ----------------------------------------------------------------------------
//// Título:    SaveImage
////
//// Fecha:    02/03/2013
//// Autor:    Alex Solé
//// ----------------------------------------------------------------------------


//using System.IO;

//private HistoryViewModel SaveImage(HistoryViewModel history,HttpPostedFileBase file)
//        {
//            if (file != null)
//            {
//                if (file.ContentLength > 0)
//                {
//                    string filepath = Path.GetFileName(file.FileName);
//                    string path = Server.MapPath("~" + Util.URL_IMAGES) + filepath;
//                    string URLpath = Util.URL_IMAGES + filepath;

//                    if (!System.IO.File.Exists(path))
//                    {
//                        file.SaveAs(path);
//                    }

//                    history.PageItem.UrlImagen = URLpath;
//                    if (history.PageItem.Image.Common)
//                        history.PageItem.Image.ImageCommon = URLpath;
//                }
//            }

//            return history;
//        }


