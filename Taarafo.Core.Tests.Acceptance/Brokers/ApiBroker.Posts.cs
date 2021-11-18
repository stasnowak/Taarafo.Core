﻿// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE TO CONNECT THE WORLD
// ---------------------------------------------------------------

using System;
using System.Threading.Tasks;
using Taarafo.Core.Tests.Acceptance.Models.Posts;

namespace Taarafo.Core.Tests.Acceptance.Brokers
{
    public partial class ApiBroker
    {
        private const string PostsRelativeUrl = "api/posts";

        public async ValueTask<Post> PostPostAsync(Post post) =>
            await this.apiFactoryClient.PostContentAsync(PostsRelativeUrl, post);

        public async ValueTask<Post> GetPostByIdAsync(Guid postId) =>
            await this.apiFactoryClient.GetContentAsync<Post>($"{PostsRelativeUrl}/{postId}");

        public async ValueTask<Post> DeletePostByIdAsync(Guid postId) =>
            await this.apiFactoryClient.DeleteContentAsync<Post>($"{PostsRelativeUrl}/{postId}");
    }
}
