﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Telegram.Api.TL;
using Unigram.ViewModels.Channels;
using Unigram.Views.Users;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace Unigram.Views.Channels
{
    public sealed partial class ChannelAdminsPage : Page
    {
        public ChannelAdminsViewModel ViewModel => DataContext as ChannelAdminsViewModel;

        public ChannelAdminsPage()
        {
            InitializeComponent();
            DataContext = UnigramContainer.Current.ResolveType<ChannelAdminsViewModel>();
        }

        private void ListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (e.ClickedItem is TLChannelParticipantBase participant && participant.User != null)
            {
                // TODO: Layer 68
                //if (participant is TLChannelParticipantAdmin)
                //{
                //    ViewModel.NavigationService.Navigate(typeof(ChannelAdminRightsPage), TLTuple.Create(ViewModel.Item.ToPeer(), participant.User.ToPeer()));
                //}
                //else if (participant is TLChannelParticipantBanned)
                //{
                //    ViewModel.NavigationService.Navigate(typeof(ChannelBannedRightsPage), TLTuple.Create(ViewModel.Item.ToPeer(), participant.User.ToPeer()));
                //}
                //else
                {
                    ViewModel.NavigationService.Navigate(typeof(UserDetailsPage), participant.User.ToPeer());
                }
            }
        }
    }
}
