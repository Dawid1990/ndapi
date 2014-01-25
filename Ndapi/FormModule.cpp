#include "stdafx.h"
#include "FormModule.h"

using namespace System::IO;

namespace Ndapi
{
	FormModule::FormModule(d2fob* form_module) : NdapiObject(form_module)
	{
	}

	FormModule^ FormModule::Open(String^ file)
	{
		if (!File::Exists(file)) {
			throw gcnew FileNotFoundException("Module file not found", file);
		}

		auto filename = StringToText(file);

		d2ffmd* form_module;
		auto status = d2ffmdld_Load(NdapiContext::Context, &form_module, filename, FALSE);
		if (status != D2FS_SUCCESS)
		{
			throw gcnew NdapiException(String::Format("Error opening the form module. Path: {0}", file), status);
		}

		return gcnew FormModule(form_module);
	}

	NdapiEnumerator<ProgramUnit^>^ FormModule::ProgramUnits::get()
	{
		return gcnew NdapiEnumerator<ProgramUnit^>(internal_object, D2FP_PROG_UNIT);
	}

	FormModule::~FormModule() {
		d2ffmdde_Destroy(NdapiContext::Context, (d2ffmd*)internal_object);
	}
}