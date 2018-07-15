//// ----------------------------------------------------------------------------
//// Título:    NullReferenceException
////
//// Fecha:     02/03/2013
//// Autor:    Alex Solé
//// ----------------------------------------------------------------------------


//public void SaveNotification(Notification notification)
//{
//    if (notification == null)
//        throw new NullReferenceException("Item null");

//    _notificationRepository.Add(notification);

//    using (TransactionScope trans = new TransactionScope())
//    {
//        try
//        {
//            _notificationRepository.UnitOfWork.CommitAndRefreshChanges();
//            trans.Complete();
//        }
//        catch (Exception ex)
//        {
//            throw ex;
//        }
//        finally
//        {
//            trans.Dispose();
//        }
//    }
//}
