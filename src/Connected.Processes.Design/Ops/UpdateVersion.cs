using Connected.Entities;
using Connected.Notifications;
using Connected.Processes.Design.Dtos;
using Connected.Services;
using Connected.Storage;

namespace Connected.Processes.Design.Ops;

internal sealed class UpdateVersion(IProcessVersionService versions, IStorageProvider storage, IEventService events, IProcessVersionCache cache)
	: ServiceAction<IUpdateProcessVersionDto>
{
	protected override async Task OnInvoke()
	{
		SetState(await versions.Select(Dto));

		await storage.Open<ProcessVersion>().Update(Dto.AsEntity<ProcessVersion>(State.Default), Dto, async () =>
		{
			await cache.Remove(Dto.Id);

			return SetState(await versions.Select(Dto)) as ProcessVersion;
		}, Caller);

		await events.Updated(this, versions, Dto.Id);
	}
}
