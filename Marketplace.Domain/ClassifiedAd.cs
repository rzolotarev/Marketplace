﻿using System;
using Marketplace.Domain;

namespace Marketplace.Framework
{
    public class ClassifiedAd
    {
        public ClassifiedAdId Id { get; }

        private UserId _ownerId;
        private string _title;
        private string _text;
        private decimal _price;

        public ClassifiedAd(ClassifiedAdId id, UserId ownerId)
        {        
            Id = id;
            _ownerId = ownerId;
        }

        public void CreateClassifiedAd(ClassifiedAdId id, UserId ownerId)
        {
            var classifiedAd = new ClassifiedAd(id, ownerId);

            // store the entity somehow
        }

        public void SetTitle(string title) => _title = title;

        public void UpdateText(string text) => _text = text;

        public void UpdatePrice(decimal price) => _price = price;
    }
}
