param (
    [Parameter(Mandatory)]
    [ValidateSet("PSGallery", "DailyBuild", "Sign", IgnoreCase = $false)]
    [string] $Source,

    [Parameter()]
    [string] $AzPackagesLocation
)

switch ($Source) {
    "PSGallery" {
        Set-PSRepository -Name $Source -InstallationPolicy Trusted
    }
    { "DailyBuild" -or "Sign" } {
        Register-PSRepository -Name $Source -SourceLocation $AzPackagesLocation -PackageManagementProvider NuGet -InstallationPolicy Trusted
    }
}

Install-Module -Name AzPreview -Repository $Source -Scope CurrentUser -AllowClobber -Force
