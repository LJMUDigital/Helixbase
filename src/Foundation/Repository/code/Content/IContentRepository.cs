﻿using Helixbase.Foundation.Model;

namespace Helixbase.Foundation.Repository.Content
{
    public interface IContentRepository
    {
        T GetContentItem<T>(string contentGuid) where T : class, ISitecoreItem;
    }
}